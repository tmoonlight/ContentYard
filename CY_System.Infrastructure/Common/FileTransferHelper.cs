using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using CY_System.DomainStandard;
using System.Net;
using System.IO;

namespace CY_System.Infrastructure.Common
{
    /// <summary>
    /// 文件传输帮助类
    /// </summary>
    public class FileTransferHelper
    {
        /// <summary>
        /// 文件上传
        /// </summary>
        /// <param name="uploadfile"></param>
        /// <param name="url"></param>
        /// <param name="fileFormName"></param>
        /// <param name="contenttype"></param>
        /// <returns></returns>
        public static string UploadFileEx(string uploadfile, string url,
        string fileFormName, string contenttype)
        {
            if ((fileFormName == null) ||
                (fileFormName.Length == 0))
            {
                fileFormName = "file";
            }

            if ((contenttype == null) ||
                (contenttype.Length == 0))
            {
                contenttype = "application/octet-stream";
            }


            string postdata;
            postdata = "?";

            Uri uri = new Uri(url + postdata);


            string boundary = "----------" + DateTime.Now.Ticks.ToString("x");
            HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(uri);
            webrequest.ContentType = "multipart/form-data; boundary=" + boundary;
            webrequest.Method = "POST";


            StringBuilder sb = new StringBuilder();
            sb.Append("--");
            sb.Append(boundary);
            sb.Append("\r\n");
            sb.Append("Content-Disposition: form-data; name=\"");
            sb.Append(fileFormName);
            sb.Append("\"; filename=\"");
            sb.Append(Path.GetFileName(uploadfile));
            sb.Append("\"");
            sb.Append("\r\n");
            sb.Append("Content-Type: ");
            sb.Append(contenttype);
            sb.Append("\r\n");
            sb.Append("\r\n");

            string postHeader = sb.ToString();
            byte[] postHeaderBytes = Encoding.UTF8.GetBytes(postHeader);

            //注意 这里要加一个魔性的空格,否则无法调用到
            //http://192.168.51.170:2003/swagger-ui.html#!/file-controller/uploadFile2FastDfsUsingPOST
            byte[] boundaryBytes =
                   Encoding.ASCII.GetBytes("\r\n--" + boundary + " \r\n");

            using (FileStream fileStream = new FileStream(uploadfile,
                                        FileMode.Open, FileAccess.Read))
            {
                long length = postHeaderBytes.Length + fileStream.Length +
                                                       boundaryBytes.Length;
                webrequest.ContentLength = length;

                Stream requestStream = webrequest.GetRequestStream();

                requestStream.Write(postHeaderBytes, 0, postHeaderBytes.Length);

                byte[] buffer = new Byte[checked((uint)Math.Min(4096,
                                         (int)fileStream.Length))];
                int bytesRead = 0;
                while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
                    requestStream.Write(buffer, 0, bytesRead);

                requestStream.Write(boundaryBytes, 0, boundaryBytes.Length);
                WebResponse responce = webrequest.GetResponse();
                Stream s = responce.GetResponseStream();
                StreamReader sr = new StreamReader(s);


                return sr.ReadToEnd();
            }
        }

        }
}
