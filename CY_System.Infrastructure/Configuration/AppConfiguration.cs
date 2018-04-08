using CY_System.DomainStandard;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;

namespace CY_System.Infrastructure
{
    public static class AppConfiguration
    {
        private static readonly ConcurrentDictionary<string, IConfigurationRoot> _configurationCache;

        static AppConfiguration()
        {
            _configurationCache = new ConcurrentDictionary<string, IConfigurationRoot>();
        }

        /// <summary>
        /// 从全局缓存获取配置对象,如获取不到则从配置文件里取到缓存中
        /// </summary>
        /// <param name="projectName">默认读CY_System.Service的配置</param>
        /// <param name="path"></param>
        /// <param name="environmentName"></param>
        /// <returns></returns>
        public static IConfigurationRoot Get(string projectName, string path = null, string environmentName = null)
        {
            //var cacheKey = path + "#" + environmentName;// + "#" + addUserSecrets;
            var cacheKey = projectName;
            return _configurationCache.GetOrAdd(
                cacheKey,
                _ => BuildConfiguration(path, environmentName)
            );
        }


        /// <summary>
        /// 获取一整个配置节,如果有多层则用冒号分割 eg.:
        /// var x = GetSection("ConnectionStrings:Default")
        /// </summary>
        /// <param name="sectionName"></param>
        /// <returns></returns>
        public static IConfigurationSection GetSection(string sectionName, string projectName = CY_SystemConsts.ServiceProjectName)
        {
            IConfigurationRoot root = AppConfiguration.Get(projectName);
            return root.GetSection(sectionName);
        }


        /// <summary>
        /// 直接获取配置值,如果有多层则用冒号分割 eg.:
        /// var x = GetValue("ConnectionStrings:Default")
        /// </summary>
        /// <param name="sectionName"></param>
        /// <returns></returns>
        public static string GetValue(string sectionName, string projectName = CY_SystemConsts.ServiceProjectName)
        {
            IConfigurationRoot root = AppConfiguration.Get(projectName);
            return root.GetSection(sectionName).Value;
        }


        /// <summary>
        /// 获取缓存配置
        /// </summary>
        /// <param name="path"></param>
        /// <param name="environmentName"></param>
        /// <returns></returns>
        private static IConfigurationRoot BuildConfiguration(string path, string environmentName = null)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(path)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            if (!string.IsNullOrEmpty(environmentName))
            {
                builder = builder.AddJsonFile($"appsettings.{environmentName}.json", optional: true);
            }

            builder = builder.AddEnvironmentVariables();

            return builder.Build();
        }

    }
}
