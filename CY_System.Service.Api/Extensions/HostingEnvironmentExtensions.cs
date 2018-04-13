using CY_System.DomainStandard;
using CY_System.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace CY_System.Service
{
    /// <summary>
    /// 对全局环境配置的扩展
    /// </summary>
    public static class HostingEnvironmentExtensions
    {
        public static IConfigurationRoot GetAppConfiguration(this IHostingEnvironment env, string ProjectName)
        {
            return AppConfiguration.Get(ProjectName, env.ContentRootPath, env.EnvironmentName);
        }
    }
}
