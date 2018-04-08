using CY_System.DomainStandard;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace CY_System.Infrastructure
{
    /// <summary>
    /// 数据库连接工厂,可通过修改配置设置数据库类型
    /// </summary>
    public class ConnectionFactory
    {
        /// <summary>
        /// 建立连接
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="DbSetting">连接字符串配置节参数(注意! 是配置节参数,不是连接字符串)</param>
        /// <returns></returns>
        public static IDbConnection CreateConnection<T>(string DbSetting) where T : IDbConnection, new()
        {
            IDbConnection connection = new T();
            //connection.ConnectionString = "server=192.168.4.223;database=CA;User ID=cyyz;Password=cyyz7201;Connect Timeout=120;"; //ConnectionConfig.ConnectionString;拿到 app里
            connection.ConnectionString = (AppConfiguration.Get(CY_SystemConsts.ServiceProjectName).GetConnectionString(DbSetting));
            connection.Open();
            return connection;
        }

        /// <summary>
        /// 建立连接
        /// </summary>
        /// <param name="DbSetting"></param>
        /// <returns></returns>
        public static IDbConnection CreateConnection(string DbSetting, string DbType = "sqlserver")
        {
            if (DbType.ToLower() == "sqlite")
            {
                return CreateConnection<Microsoft.Data.Sqlite.SqliteConnection>(DbSetting);
            }
            //通过配置修改数据库连接
            return CreateConnection<System.Data.SqlClient.SqlConnection>(DbSetting);
        }
    }
}
