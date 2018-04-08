//using Microsoft.CSharp;
//using System;
//using System.CodeDom;
//using System.CodeDom.Compiler;
//using System.Web.Services.Description;
//using System.Xml;
//using System.Net;
//using System.Net.Security;
//using System.Collections.Generic;
//using System.Security.Cryptography.X509Certificates;

//namespace CY_System.Infrastructure.Common
//{
//    public class WebServiceHelper
//    {
//        //动态调用web服务
//        public static object InvokeWebService(string url, string methodname, object[] args)
//        {
//            return WebServiceHelper.InvokeWebService(url, null, methodname, args);
//        }

//        public static object InvokeWebService(string url, string classname, string methodname, object[] args)
//        {
//            if ((classname == null) || (classname == ""))
//            {
//                classname = WebServiceHelper.GetWsClassName(url);
//            }

//            try
//            {
//                //使用 Stream 对象，创建和格式化 WSDL 文档
//                //WebClient wc = new WebClient();
//                //Stream stream = wc.OpenRead(url + "?WSDL");
//                //ServiceDescription sd = ServiceDescription.Read(stream);

//                //使用 XmlTextReader 对象，创建和格式化 WSDL 文档
//                XmlTextReader reader = new XmlTextReader(url + "?wsdl");
//                curssl.disposecert(GetServerName(url));
//                ServiceDescription sd = ServiceDescription.Read(reader);

//                ServiceDescriptionImporter sdi = new ServiceDescriptionImporter();
//                sdi.AddServiceDescription(sd, "", "");
//                CodeNamespace cn = new CodeNamespace();

//                // 生成客户端代理类代码
//                CodeCompileUnit ccu = new CodeCompileUnit();
//                ccu.Namespaces.Add(cn);
//                sdi.Import(cn, ccu);

//                CSharpCodeProvider csc = new CSharpCodeProvider();
//                ICodeCompiler icc = csc.CreateCompiler();

//                // 设定编译参数
//                CompilerParameters cplist = new CompilerParameters();
//                cplist.GenerateExecutable = false;
//                cplist.GenerateInMemory = true;
//                cplist.ReferencedAssemblies.Add("System.dll");
//                cplist.ReferencedAssemblies.Add("System.XML.dll");
//                cplist.ReferencedAssemblies.Add("System.Web.Services.dll");
//                cplist.ReferencedAssemblies.Add("System.Data.dll");

//                // 编译代理类
//                CompilerResults cr = icc.CompileAssemblyFromDom(cplist, ccu);
//                if (true == cr.Errors.HasErrors)
//                {
//                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
//                    foreach (System.CodeDom.Compiler.CompilerError ce in cr.Errors)
//                    {
//                        sb.Append(ce.ToString());
//                        sb.Append(System.Environment.NewLine);
//                    }
//                    throw new Exception(sb.ToString());
//                }

//                // 生成代理实例，并调用方法
//                System.Reflection.Assembly assembly = cr.CompiledAssembly;
//                Type t = assembly.GetType(classname, true, true);
//                object obj = Activator.CreateInstance(t);

//                System.Reflection.MethodInfo mi = t.GetMethod(methodname);

//                return mi.Invoke(obj, args);
//            }
//            catch (Exception ex)
//            {
//                throw new Exception(ex.InnerException.Message, new Exception(ex.InnerException.StackTrace));
//            }
//        }

//        private static string GetWsClassName(string wsUrl)
//        {
//            string[] parts = wsUrl.Split('/');
//            string[] pps = parts[parts.Length - 1].Split('.');

//            return pps[0];
//        }

//        private static string GetServerName(string wsUrl)
//        {
//            string strurl = string.Empty;
//            if (wsUrl.ToLower().StartsWith("https://"))
//                strurl = wsUrl.Substring(8);
//            else if (wsUrl.ToLower().StartsWith("http://"))
//                strurl = wsUrl.Substring(7);

//            if (strurl.Contains(":"))
//                strurl = strurl.Substring(0, strurl.IndexOf(":"));
//            else
//                strurl = strurl.Substring(0, strurl.IndexOf("/"));

//            return strurl;
//        }

//        /// <summary>
//        /// 跳过证书验证
//        /// </summary>
//        public class curssl
//        {
//            private static string m_ServerName = string.Empty;

//            public static void disposecert(string serverName)
//            {
//                m_ServerName = serverName;

//                //trust sender
//                ServicePointManager.ServerCertificateValidationCallback
//                 = ((sender, cert, chain, errors) => cert.Subject.Contains(m_ServerName));                

//                //validate cert by calling a function
//                ServicePointManager.ServerCertificateValidationCallback
//                    += new RemoteCertificateValidationCallback(ValidateRemoteCertificate);
//            }

//            /// <summary>
//            /// callback used to validate the certificate in an SSL conversation
//            /// </summary>
//            /// <param name="sender"></param>
//            /// <param name="cert"></param>
//            /// <param name="chain"></param>
//            /// <param name="policyErrors"></param>
//            /// <returns></returns>
//            private static bool ValidateRemoteCertificate(object sender, X509Certificate cert,
//                X509Chain chain, SslPolicyErrors policyErrors)
//            {
//                return true;
//            }
//        }
//    }

//}
