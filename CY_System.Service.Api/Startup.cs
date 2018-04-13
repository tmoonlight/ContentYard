using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.PlatformAbstractions;
using System.IO;
using Swashbuckle.AspNetCore.Swagger;
using CY_System.Infrastructure;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using CY_System.DomainStandard;

namespace CY_System.Service
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //注入NodeService(NodeJS互操作)
            services.AddNodeServices();
            services.AddMvc().AddJsonOptions(options => options.SerializerSettings.ContractResolver
        = new Newtonsoft.Json.Serialization.DefaultContractResolver());//JSON首字母小写解决;

            //加入jwt校验
            services.AddAuthentication(options => {
                options.DefaultAuthenticateScheme = "JwtBearer";
                options.DefaultChallengeScheme = "JwtBearer";
            })
                .AddJwtBearer("JwtBearer", jwtBearerOptions =>
                {
                    jwtBearerOptions.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(CY_SystemConsts.SecurityKey)),

                        ValidateIssuer = true,
                        ValidIssuer = CY_SystemConsts.TokenIssuer,

                        ValidateAudience = true,
                        ValidAudience = CY_SystemConsts.TokenAudience,

                        ValidateLifetime = true, //token缓冲

                        ClockSkew = TimeSpan.FromMinutes(5) //token过期后有"5"分钟缓冲时间
                    };
                });

            //加入swagger
            services.AddSwaggerGen(op =>
            {
                op.SwaggerDoc("v1", new Info() { Version = "v1", Title = "" });
                
                //设置api xml的地址
                var xmlpath = Path.Combine(PlatformServices.Default.Application.ApplicationBasePath, "Cyyz.Api.xml");
                op.IncludeXmlComments(xmlpath);
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            const string PROJECT_NAME = "CY_System.Service";
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Cyyz Api V1");
                c.DocExpansion("none");
            });
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
           
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "CA",
                    template: "CA/{controller=Home}/{action=Index}/{id?}");
            });
            app.UseStaticFiles(new StaticFileOptions
            {            
                ServeUnknownFileTypes = true
            });
            //应用程序配置
            env.GetAppConfiguration(PROJECT_NAME);

            //配置Dapper扩展的表映射规则
            DapperExtensions.DapperExtensions.DefaultMapper = typeof(CustomPluralizedMapper<>);


        }
    }
}
