using CY_System.DomainStandard;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;
using Qiniu.Util;
using Qiniu.IO.Model;
using Qiniu.Common;
using Qiniu.RS;
using Qiniu.RS.Model;
using Qiniu.IO;
using Qiniu.Http;
using Qiniu.CDN;
using Qiniu.CDN.Model;

namespace CY_System.Infrastructure.Repository
{
    /// <summary>
    /// 自动更新仓库
    /// </summary>
    public class AutoUpdateRepository
    {
        private BaseRepository_AutoUpdate<QiNiuInfo> brQiNiuInfo = new BaseRepository_AutoUpdate<QiNiuInfo>();
        private BaseRepository_AutoUpdate<UpdateVerInfo> brUpdateVerInfo = new BaseRepository_AutoUpdate<UpdateVerInfo>();
        private BaseRepository_AutoUpdate<AppUpdateVerInfo> brAppUpdateVerInfo = new BaseRepository_AutoUpdate<AppUpdateVerInfo>();

        private string AccessKey = string.Empty;//"sYRgIAGpnGj4sTFI-p82HL7dNKKWsO2c71N18llT";
        private string SecretKey = string.Empty;//"P4xvdWkUtyBvBc3IskoHN2_54CGAIwB31y27seEr";
        private string Bucket = string.Empty;//"cyyz-erp";// 空间名
        private string Domain = string.Empty;//http://erp.cysignet.com

        /// <summary>
        /// 提交自动更新程序更新
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int AddAutoUpdateAppVer(AppUpdateVerInfo info)
        {
            using (var conn = brAppUpdateVerInfo.GetConnection())
            {
                string sql = @"INSERT INTO tb_AppUpdateVer
                                           (Ver
                                           ,UpdatePackName
                                           ,UpdateTime
                                           ,Remark)
                                      VALUES
                                           (@Ver
                                           ,@UpdatePackName
                                           ,datetime(CURRENT_TIMESTAMP,'localtime')
                                           ,@Remark)";
                return conn.Execute(sql, new { Ver = info.Ver, UpdatePackName = info.UpdatePackName, Remark = info.Remark });
            }
        }
        /// <summary>
        /// 提交版本更新
        /// </summary>
        /// <param name="info"></param>
        /// <returns></returns>
        public int AddVer(UpdateVerInfo info)
        {
            using (var conn = brUpdateVerInfo.GetConnection())
            {
                string sql = @"INSERT INTO tb_UpdateVer
                                           (Ver
                                           ,UpdatePackName
                                           ,UpdateTime
                                           ,Remark)
                                      VALUES
                                           (@Ver
                                           ,@UpdatePackName
                                           ,datetime(CURRENT_TIMESTAMP,'localtime')
                                           ,@Remark)";
                return conn.Execute(sql, new { Ver = info.Ver, UpdatePackName = info.UpdatePackName, Remark = info.Remark });
            }
        }

        public int UpdateAutoUpdateAppVer(AppUpdateVerInfo info)
        {
            using (var conn = brAppUpdateVerInfo.GetConnection())
            {
                string sql = @"Update tb_AppUpdateVer SET
                                           Ver = @Ver
                                           ,UpdatePackName = @UpdatePackName
                                           ,UpdateTime = datetime(CURRENT_TIMESTAMP,'localtime')
                                      Where ID = @ID";
                return conn.Execute(sql, new { Ver = info.Ver, UpdatePackName = info.UpdatePackName, ID = info.ID });
            }
        }
        /// <summary>
        /// 获取自动更新程序的版本信息
        /// </summary>
        /// <returns></returns>
        public AppUpdateVerInfo GetAutoUpdateAppInfo()
        {
            using (var conn = brQiNiuInfo.GetConnection())
            {
                var returnvalue = conn.Query<AppUpdateVerInfo>(@"select * from tb_AppUpdateVer where Flag >=0 order by ID desc limit 1");
                List<AppUpdateVerInfo> lst = returnvalue.AsList<AppUpdateVerInfo>();
                if (lst.Count > 0)
                {
                    return lst[0];
                }
                else
                {
                    return null;
                }
            }
        }
        /// <summary>
        /// 获取上传令牌
        /// </summary>
        /// <param name="name">上传文件名字</param>
        /// <returns></returns>
        public string GetUploadToken(string key)
        {
            GetQiNiuInfo();
            Mac mac = new Mac(AccessKey, SecretKey);
            //设置上传策略，详见：https://developer.qiniu.com/kodo/manual/1206/put-policy
            PutPolicy putPolicy = new PutPolicy();
            putPolicy.Scope = Bucket + ":" + key;
            putPolicy.SetExpires(14400);
            return Auth.CreateUploadToken(mac, putPolicy.ToJsonString());
        }
        /// <summary>
        /// 根据文件名获生成下载地址
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetDownloadUrl(string name)// "tv_xt70.rar";
        {
            GetQiNiuInfo();
            Mac mac = new Mac(AccessKey, SecretKey);            
            int expireInSeconds = 14400;// 设置下载链接有效期秒
            //string rawUrl = "http://your-bucket.bkt.clouddn.com/1.jpg";
            //return DownloadManager.CreatePrivateUrl(mac, Domain, name, expireInSeconds);
            return DownloadManager.CreateSignedUrl(mac, Domain + "/" + name, expireInSeconds);
        }
        /// <summary>
        /// 刷新文件的CDN缓存
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool RefreshCDNUrl(string key)
        {
            GetQiNiuInfo();
            Mac mac = new Mac(AccessKey, SecretKey);
            CdnManager manager = new CdnManager(mac);
            //URL 列表
            string[] urls = { string.Format("{0}/{1}", Domain, key) };
            RefreshResult ret = manager.RefreshUrls(urls);
            return (ret.Code == (int)HttpCode.OK);
        }
        /// <summary>
        /// 获取七牛帐号信息
        /// </summary>
        private void GetQiNiuInfo()
        {
            using (var conn = brQiNiuInfo.GetConnection())
            {
                var returnvalue = conn.Query(@"select * from tb_QiNiu ");
                List<dynamic> lst = returnvalue.AsList<dynamic>();
                if (lst.Count > 0)
                {
                    dynamic d = lst[0];
                    this.AccessKey = d.AccessKey;
                    this.SecretKey = d.SecretKey;
                    this.Bucket = d.Bucket;
                    this.Domain = d.Domain;
                }
                else
                {
                    throw new Exception("查找不到七牛帐号信息。");
                }
            }
        }
        /// <summary>
        /// 获取七牛云上的文件列表
        /// </summary>
        /// <returns></returns>
        public List<string> GetListFiles()
        {
            GetQiNiuInfo();
            List<string> lst = new List<string>();
            string marker = ""; // 首次请求时marker必须为空
            string prefix = null; // 按文件名前缀保留搜索结果
            string delimiter = null; // 目录分割字符(比如"/")
            int limit = 100; // 单次列举数量限制(最大值为1000)
            // 设置存储区域
            //Config config = new Config();
            //config.Zone = Zone.ZONE_CN_South;
            Mac mac = new Mac(AccessKey, SecretKey);
            BucketManager bucketManager = new BucketManager(mac);
            do
            {
                ListResult result = bucketManager.ListFiles(Bucket, prefix, marker, limit, delimiter);
                foreach (var itm in result.Result.Items)
                {
                    lst.Add(itm.Key);
                }
                marker = result.Result.Marker;
            } while (!string.IsNullOrEmpty(marker));
            lst.Sort();
            return lst;
        }
        /// <summary>
        /// 删除七牛云上的文件
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool DelFile(string key)
        {
            GetQiNiuInfo();
            Mac mac = new Mac(AccessKey, SecretKey);
            BucketManager bucketManager = new BucketManager(mac);
            HttpResult result = bucketManager.Delete(Bucket, key);
            if (result.Code != (int)HttpCode.OK)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        /// <summary>
        /// 获取最新版本号
        /// </summary>
        /// <returns></returns>
        public string GetVer()
        {
            using (var conn = brQiNiuInfo.GetConnection())
            {
                var returnvalue = conn.Query(@"select * from tb_UpdateVer where Flag >=0 order by ID desc limit 1");
                List<dynamic> lst = returnvalue.AsList<dynamic>();
                if (lst.Count > 0)
                {
                    return string.Format("{0}", lst[0].Ver);
                }
                else
                {
                    return string.Empty;
                }
            }
        }
        /// <summary>
        /// 客户端存在版本号
        /// </summary>
        /// <param name="ver"></param>
        /// <returns></returns>
        public bool ExistVer(string ver)
        {
            using (var conn = brQiNiuInfo.GetConnection())
            {
                var returnvalue = conn.Query(@"select ID from tb_UpdateVer where Flag >=0 and Ver = @Ver", new { Ver = ver });
                List<dynamic> lst = returnvalue.AsList<dynamic>();
                if (lst.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// 更新App存在版本号
        /// </summary>
        /// <param name="ver"></param>
        /// <returns></returns>
        public bool ExistAutoUpdateAppVer(string ver)
        {
            using (var conn = brQiNiuInfo.GetConnection())
            {
                var returnvalue = conn.Query(@"select ID from tb_AppUpdateVer where Flag >=0 and Ver = @Ver", new { Ver = ver });
                List<dynamic> lst = returnvalue.AsList<dynamic>();
                if (lst.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        /// <summary>
        /// 获取更新列表
        /// </summary>
        /// <param name="OldVer"></param>
        /// <returns></returns>
        public IEnumerable<UpdateVerInfo> GetUpdateList(string OldVer)
        {
            using (var conn = brQiNiuInfo.GetConnection())
            {
                var returnvalue = conn.Query<UpdateVerInfo>(@"select * from tb_UpdateVer where ID > (select ID from tb_UpdateVer where Ver = @Ver) and Flag >=0 order by ID asc", new { Ver = OldVer });
                return returnvalue;
            }
        }
    }
}
