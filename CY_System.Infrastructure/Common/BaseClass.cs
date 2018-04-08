using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

using Dapper;
using System.Data.SqlClient;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using SealWebService;
using System.Threading.Tasks;
using CY_System.DomainStandard;

namespace CY_System.Infrastructure
{
    /// <summary>
    /// 
    /// 作者：田大伟
    /// 时间：2015-01-27 10:42:49
    /// </summary>
    public class BaseClass
    {

        #region 其他
        /// <summary>
        /// HttpGet
        /// </summary>
        /// <param name="url"></param>
        /// <param name="paramsValue"></param>
        /// <returns></returns>
        public static string HttpGetMath(string url, string paramsValue)
        {
            string result = string.Empty;
            Uri uri = new Uri(url);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri + "/" + paramsValue);
            request.Method = "Get";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            result = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return result;
        }

        /// <summary>
        /// 获取数据库时间
        /// </summary>
        /// <returns></returns>
        public static DateTime GetSystemDate()
        {
            using (var conn = ConnectionFactory.CreateConnection(CY_SystemConsts.ConnectionString_conn))
            {
                //string strSql = @"SELECT [value] FROM [UFDATA_006_2015].[dbo].[base_configuration] WHERE [Key]=@key";
                return conn.QueryFirst<DateTime>("SELECT GETDATE()");
            }
        }

        /// <summary>
        /// 通过登录名获取用户
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public UserInfo SelectUserByUserId(string userId)
        {
            using (var conn = ConnectionFactory.CreateConnection(CY_SystemConsts.ConnectionString_conn))
            {
                StringBuilder strSql = new StringBuilder();
                strSql.Append(@"select uu.cUser_Id,uu.cUser_Name,uu.cPassword,hhp.cPsn_Name,hhp.cPsnMobilePhone,hhp.rEmployState from UFSystem.dbo.UA_User uu Join hr_hi_person hhp on uu.cUser_Name=hhp.cPsn_Num ");
                strSql.Append(@" where cUser_Id=@userId");
                var userInfo = conn.QueryFirst<UserInfo>(strSql.ToString(),new { @userId = userId });
               
                return userInfo;
            }
        }

        /// <summary>
        /// 读取单个配置
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetSystemConfiguration(string key)
        {
            using (var conn = ConnectionFactory.CreateConnection(CY_SystemConsts.ConnectionString_conn))
            {
                string strSql = @"SELECT [value] FROM [UFDATA_006_2015].[dbo].[base_configuration] WHERE [Key]=@key";
                return conn.QueryFirst<string>(strSql, new { @key = key });
            }
        }

        /// <summary>
        /// HttpGet
        /// </summary>
        /// <param name="url"></param>
        /// <param name="paramsValue"></param>
        /// <returns></returns>
        public static string HttpGetMathParams(string url, string paramsValue)
        {
            string result = string.Empty;
            Uri uri = new Uri(url);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri + "?" + paramsValue);
            request.Method = "Get";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            result = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return result;
        }

        /// <summary>
        /// HttpGet
        /// </summary>
        /// <param name="url"></param>
        /// <param name="paramsValue"></param>
        /// <returns></returns>
        public static string HttpGetMath(string url, string paramsValue, string paramsValue1)
        {
            string result = string.Empty;
            Uri uri = new Uri(url);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri + "/" + paramsValue + "/" + paramsValue1);
            request.Method = "Get";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            result = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return result;
        }

        /// <summary>
        /// HttpPost
        /// </summary>
        /// <param name="url"></param>
        /// <param name="paramsValue"></param>
        /// <returns></returns>
        public static string HttpPostMath(string url, string paramsValue, Dictionary<string, string> headers)
        {
            string result = string.Empty;
            byte[] byteArray = Encoding.UTF8.GetBytes(paramsValue);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            if (headers != null && headers.Count > 0)
            {
                foreach (KeyValuePair<string, string> kvp in headers)
                {
                    request.Headers.Add(kvp.Key, kvp.Value);
                }
            }
            request.ContentLength = byteArray.Length;
            using (Stream newStream = request.GetRequestStream())
            {
                newStream.Write(byteArray, 0, byteArray.Length);
            }
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                result = sr.ReadToEnd();
            }
            return result;
        }

        /// <summary>
        /// HttpPost
        /// </summary>
        /// <param name="url"></param>
        /// <param name="paramsValue"></param>
        /// <returns></returns>
        public static string HttpPostMath(string url, string paramsValue)
        {
            string result = string.Empty;
            byte[] byteArray = Encoding.UTF8.GetBytes(paramsValue);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json;charset=UTF-8";
            request.ContentLength = byteArray.Length;
            using (Stream newStream = request.GetRequestStream())
            {
                newStream.Write(byteArray, 0, byteArray.Length);
            }
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (StreamReader sr = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
            {
                result = sr.ReadToEnd();
            }
            return result;
        }


        /// <summary>
        /// AES解密(ECB)
        /// </summary>
        /// <param name="decryptStr">密文</param>
        /// <param name="key">密钥</param>
        /// <returns></returns>
        public static string Decrypt(string decryptStr, string key)
        {
            byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key);
            byte[] toEncryptArray = Convert.FromBase64String(decryptStr);
            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.ECB;
            rDel.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = rDel.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        /// <summary>
        /// AES加密(ECB)
        /// </summary>
        /// <param name="encryptStr">明文</param>
        /// <param name="key">密钥</param>
        /// <returns></returns>
        public static string Encrypt(string encryptStr, string key)
        {
            byte[] keyArray = UTF8Encoding.UTF8.GetBytes(key);
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(encryptStr);
            RijndaelManaged rDel = new RijndaelManaged();
            rDel.Key = keyArray;
            rDel.Mode = CipherMode.ECB;
            rDel.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = rDel.CreateEncryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        ///// <summary>
        ///// Json 字符串 转换为 DataTable数据集合
        ///// </summary>
        ///// <param name="json"></param>
        ///// <returns></returns>
        //public static DataTable JsonToDataTable(string json)
        //{
        //    DataTable dataTable = new DataTable();  //实例化
        //    DataTable result;
        //    try
        //    {
        //        System.Web.Script.Serialization.JavaScriptSerializer javaScriptSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();
        //        javaScriptSerializer.MaxJsonLength = Int32.MaxValue; //取得最大数值
        //        System.Collections.ArrayList arrayList = javaScriptSerializer.Deserialize<System.Collections.ArrayList>(json);
        //        if (arrayList.Count > 0)
        //        {
        //            foreach (Dictionary<string, object> dictionary in arrayList)
        //            {
        //                if (dictionary.Keys.Count == 0)
        //                {
        //                    result = dataTable;
        //                    return result;
        //                }
        //                //Columns
        //                if (dataTable.Columns.Count == 0)
        //                {
        //                    foreach (string current in dictionary.Keys)
        //                    {
        //                        dataTable.Columns.Add(current, dictionary[current].GetType());
        //                    }
        //                }
        //                //Rows
        //                DataRow dataRow = dataTable.NewRow();
        //                foreach (string current in dictionary.Keys)
        //                {
        //                    dataRow[current] = dictionary[current];
        //                }
        //                dataTable.Rows.Add(dataRow); //循环添加行到DataTable中
        //            }
        //        }
        //    }
        //    catch
        //    {
        //    }
        //    result = dataTable;
        //    return result;
        //}

        public static string XmlToJson(string xml)
        {
            System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
            doc.LoadXml(xml);
            string json = Newtonsoft.Json.JsonConvert.SerializeXmlNode(doc);
            return json;
        }

      
        #endregion


    }
}
