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
    /// 七牛云仓库
    /// </summary>
    public class QiNiuYunRepository
    {
        private BaseRepository_AutoUpdate<QiNiuInfo> brQiNiuInfo = new BaseRepository_AutoUpdate<QiNiuInfo>();

        private string AccessKey = string.Empty;//"sYRgIAGpnGj4sTFI-p82HL7dNKKWsO2c71N18llT";
        private string SecretKey = string.Empty;//"P4xvdWkUtyBvBc3IskoHN2_54CGAIwB31y27seEr";
        private string Bucket = string.Empty;//"cyyz-erp";// 空间名
        private string Domain = string.Empty;//http://erp.cysignet.com

        /// <summary>
        /// 获取上传令牌
        /// </summary>
        /// <param name="name">上传文件名字（不同项目需要加不同的前辍，例：AutoUpdate\1.rar）</param>
        /// <returns></returns>
        public string GetUploadToken(string key,int expireInSeconds = 14400)
        {
            GetQiNiuInfo();
            Mac mac = new Mac(AccessKey, SecretKey);
            //设置上传策略，详见：https://developer.qiniu.com/kodo/manual/1206/put-policy
            PutPolicy putPolicy = new PutPolicy();
            putPolicy.Scope = Bucket + ":" + key;
            putPolicy.SetExpires(expireInSeconds);
            return Auth.CreateUploadToken(mac, putPolicy.ToJsonString());
        }
        /// <summary>
        /// 根据文件名获生成下载地址
        /// </summary>
        /// <param name="name">下载文件名（不同项目需要加不同的前辍，例：AutoUpdate\1.rar）</param>
        /// <param name="expireInSeconds">设置下载链接有效期秒</param>
        /// <returns></returns>
        public string GetDownloadUrl(string name,int expireInSeconds = 14400)
        {
            GetQiNiuInfo();
            Mac mac = new Mac(AccessKey, SecretKey);            
            //string rawUrl = "http://your-bucket.bkt.clouddn.com/1.jpg";
            //return DownloadManager.CreatePrivateUrl(mac, Domain, name, expireInSeconds);
            return DownloadManager.CreateSignedUrl(mac, Domain + "/" + name, expireInSeconds);
        }
        /// <summary>
        /// 刷新文件的CDN缓存
        /// </summary>
        /// <param name="key">需要刷新CDN的文件名（不同项目需要加不同的前辍，例：AutoUpdate\1.rar）</param>
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
        public List<string> GetListFiles(string prefix)
        {
            GetQiNiuInfo();
            List<string> lst = new List<string>();
            string marker = ""; // 首次请求时marker必须为空
            //string prefix = null; // 按文件名前缀保留搜索结果
            string delimiter = null; // 目录分割字符(比如"/")
            int limit = 1000; // 单次列举数量限制(最大值为1000)
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
    }
}
