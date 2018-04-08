using System;
using System.Configuration;
using System.Data;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;

namespace CY_System.BLL
{
    /// <summary>
    /// 业务处理层公用类
    /// </summary>
    public class PubClass
    {
        /// <summary>
        /// 用来对ERP的webapi进行校验的token
        /// </summary>
        public static string JwToken { get; set; }

        public static EndpointAddress GetEPAddress(ServiceEndpoint se)
        {
            string strServerIP = m_ServerIP;
            string strNewAddr = se.Address.ToString().Replace("localhost", m_ServerIP);
            Uri eUri = new Uri(strNewAddr);
            EndpointIdentity eIdent = EndpointIdentity.CreateDnsIdentity(strServerIP);
            //AddressHeader aHeader1 = AddressHeader.CreateAddressHeader(
            //    "specialservice1", string.Format("http://{0}", eUri.Authority), 1);

            AddressHeader[] aHeaders = new AddressHeader[] { };
            EndpointAddress epAddress = new EndpointAddress(eUri, eIdent, aHeaders);

            return epAddress;
        }

        /// <summary>
        /// 当前服务器ip
        /// </summary>
        public static string m_ServerIP
        {
            get
            {
                if (ConfigurationManager.AppSettings["ClientType"] != null)
                {
                    if (ConfigurationManager.AppSettings["ClientType"].ToString() == "Web")
                    {
                        return ConfigurationManager.AppSettings["Extranet"].ToString();
                    }
                }
                string strNetType = Convert.ToString(clsXmlSetting.GetData(SettingType.NetType));
                switch (strNetType)
                {
                    case "0":
                        return m_Config.AppSettings.Settings["Intranet"].Value;
                    case "1":
                        return m_Config.AppSettings.Settings["Extranet"].Value;
                    case "2":
                        return m_Config.AppSettings.Settings["Prodnet"].Value;
                    default:
                        return m_Config.AppSettings.Settings["Extranet"].Value;
                }
            }
        }

        /// <summary>
        /// 获取配置文件
        /// </summary>
        private static Configuration m_Config
        {
            get
            {
                try
                {
                    string strConfigFile = string.Format(@"{0}\CY_System.WinUI.exe.config",
                     System.Environment.CurrentDirectory);

                    if (!File.Exists(strConfigFile))
                        throw new Exception("配置文件不存在，请设置后再处理！");

                    ExeConfigurationFileMap ecfMap = new ExeConfigurationFileMap();
                    ecfMap.ExeConfigFilename = strConfigFile;

                    return ConfigurationManager.OpenMappedExeConfiguration(ecfMap,
                        ConfigurationUserLevel.None);

                }
                catch { return null; }
            }
        }
    }

    /// <summary>
    /// 操作默认Xml默认设置
    /// </summary>
    public class clsXmlSetting
    {
        /// <summary>
        /// 读取配置文件的数据集
        /// </summary>
        /// <returns></returns>
        private static DataSet ReadData()
        {
            string strSettings = "DefaultSettings.xml";
            if (!File.Exists(strSettings))
                return null;

            DataSet ds = new DataSet();
            ds.ReadXml(strSettings);

            if (ds != null)
                return ds;
            else
                return null;
        }

        /// <summary>
        /// 写入配置文件
        /// </summary>
        /// <param name="est"></param>
        /// <param name="obj"></param>
        public static void WriteData(SettingType est, object obj, object[] objs)
        {
            DataSet ds = ReadData();
            if (ds == null)
                ds = new DataSet("DefaultSettings");

            string strSettings = "DefaultSettings.xml";
            if (File.Exists(strSettings))
                File.Delete(strSettings);

            switch (est)
            {
                case SettingType.NetType:
                    if (ds.Tables.Contains("NetType"))
                        ds.Tables["NetType"].Rows[0]["curNetType"] = obj;
                    else
                    {
                        DataTable dt = new DataTable("NetType");
                        dt.Columns.Add("curNetType", typeof(string));
                        DataRow dr = dt.NewRow();

                        dr["curNetType"] = obj;
                        dt.Rows.Add(dr);

                        ds.Tables.Add(dt);
                    }
                    break;

                case SettingType.SavePath:
                    if (ds.Tables.Contains("SavePath"))
                        ds.Tables["SavePath"].Rows[0]["CurPath"] = obj;
                    else
                    {
                        DataTable dt = new DataTable("SavePath");
                        dt.Columns.Add("CurPath", typeof(string));
                        DataRow dr = dt.NewRow();

                        dr["CurPath"] = obj;
                        dt.Rows.Add(dr);

                        ds.Tables.Add(dt);
                    }
                    break;

                case SettingType.TeamInfo:
                    if (ds.Tables.Contains("TeamInfo"))
                        ds.Tables["TeamInfo"].Rows[0].ItemArray = objs;
                    else
                    {
                        DataTable dt = new DataTable("TeamInfo");
                        dt.Columns.Add("cTeamCode", typeof(string));
                        dt.Columns.Add("cTeamName", typeof(string));
                        dt.Columns.Add("cUrgentCode", typeof(string));
                        dt.Columns.Add("cUrgentName", typeof(string));
                        dt.Columns.Add("isProduct", typeof(bool));
                        DataRow dr = dt.NewRow();

                        dr.ItemArray = objs;
                        dt.Rows.Add(dr);

                        ds.Tables.Add(dt);
                    }
                    break;

                case SettingType.LoginUser:
                    if (ds.Tables.Contains("LoginUsers"))
                    {
                        DataRow dr = ds.Tables["LoginUsers"].NewRow();
                        dr["LoginName"] = obj;
                        DataRow[] drs = ds.Tables["LoginUsers"].Select(string.Format("LoginName='{0}'", obj));
                        foreach (DataRow drR in drs)
                            drR.Delete();

                        ds.Tables["LoginUsers"].Rows.InsertAt(dr, 0);
                    }
                    else
                    {
                        DataTable dt = new DataTable("LoginUsers");
                        dt.Columns.Add("LoginName", typeof(string));
                        DataRow dr = dt.NewRow();

                        dr["LoginName"] = obj;
                        dt.Rows.Add(dr);

                        ds.Tables.Add(dt);
                    }
                    break;

            }
            ds.WriteXml(strSettings);
        }

        /// <summary>
        /// 获取配置文件记录集
        /// </summary>
        /// <returns></returns>
        public static object GetData(SettingType est)
        {
            DataSet ds = ReadData();
            if (ds == null)
                return null;

            switch (est)
            {
                case SettingType.LoginUser:
                    if (ds.Tables.Contains("LoginUsers") && ds.Tables["LoginUsers"].Rows.Count > 0)
                        return ds.Tables["LoginUsers"];
                    else
                        return null;

                case SettingType.TeamInfo:
                    if (ds.Tables.Contains("TeamInfo") && ds.Tables["TeamInfo"].Rows.Count > 0)
                        return ds.Tables["TeamInfo"].Rows[0];
                    else
                        return null;

                case SettingType.NetType:
                    if (ds.Tables.Contains("NetType") && ds.Tables["NetType"].Rows.Count > 0)
                        return Convert.ToString(ds.Tables["NetType"].Rows[0]["curNetType"]);
                    else
                        return "1";

                case SettingType.SavePath:
                    if (ds.Tables.Contains("SavePath") && ds.Tables["SavePath"].Rows.Count > 0)
                        return Convert.ToString(ds.Tables["SavePath"].Rows[0]["CurPath"]);
                    else
                        return null;

                default:
                    return null;
            }
        }

    }

    /// <summary>
    /// 枚举系统设置xml表操作类型
    /// </summary>
    public enum SettingType
    {
        TeamInfo,
        NetType,
        SavePath,
        LoginUser,
    }
}