using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CY_System.DomainStandard;
using CY_System.Infrastructure;
using CY_System.Service.Dto;
using CY_System.Service.Extensions;
using CY_System.Infrastructure.Repository;
using AutoMapper;
using System.Dynamic;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace CY_System.Service.Controllers
{
    /// <summary>
    /// Note操作控制器
    /// </summary>
    [Produces("application/json")]
    [Route("api/Base")]
    public class BaseController : Controller
    {
        private static SymmetricSecurityKey securityKey = null;

        private static SymmetricSecurityKey SecurityKey
        {
            get
            {
                if (securityKey == null)
                {
                    securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(CY_SystemConsts.SecurityKey));
                }
                return securityKey;
            }
        }

        /// <summary>
        /// 获取系统配置
        /// </summary>
        /// <param name="key">配置名</param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetSystemConfiguration")]
        public Result GetSystemConfiguration(string key)
        {
            return Result.Success(BaseClass.GetSystemConfiguration(key));
        }


        /// <summary>
        /// 获取系统数据库时间
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetSystemDate")]
        public DateTime GetSystemDate()
        {
            return BaseClass.GetSystemDate();
        }

        /// <summary>
        /// 登录并返回Json Web Token
        /// </summary>
        [AllowAnonymous]
        [HttpPost]
        [Route("Login")]
        public LoginDto Login(string userName, string password)
        {
            LoginDto ld = new LoginDto();
            BaseClass arg_0C_0 = new BaseClass();
            SecurityPolicy securityPolicy = new SecurityPolicy();
            UserInfo userInfo = arg_0C_0.SelectUserByUserId(userName);
            if (userInfo == null)
            {
                ld.Message = "用户名或密码错误，请重试！";

            }
            else
            {
                string rEmployState = userInfo.rEmployState;
                if (!(rEmployState == "10"))
                {
                    if (rEmployState == "20")
                    {
                        ld.Message = "离退用户账号，登陆失败！";
                    }
                    else if (rEmployState == "30")
                    {
                        ld.Message = "离职用户账号，登陆失败！";
                    }
                    else if (!(rEmployState == "40"))
                    {
                        ld.Message = "该用户信息异常，无法登陆！";
                    }
                    else
                    {
                        ld.Message = "停用用户账号，登陆失败！";
                    }
                }
                else
                {
                    if ((string.IsNullOrEmpty(userInfo.cPassword) && string.IsNullOrEmpty(password))
                        || (!string.IsNullOrEmpty(userInfo.cPassword)
                        && userInfo.cPassword == string.Format("{0}", securityPolicy.EnPassWord(password))))
                    {
                        ld = userInfo.MapTo<LoginDto>();
                        //获取token

                        ld.JWT = GenerateToken(userInfo);
                        return ld;
                    }
                    else
                    {
                        ld.Message = "用户名或密码错误，请重试！";
                    }
                }
            }
            //BaseClass
            return ld;
        }

        //[Authorize]
        [HttpGet]
        [Route("TestDynamic")]
        public string TestDynamic(string userName, string password)
        {
            IEnumerable<dynamic> l = new List<dynamic>() { new { a = 3, b = 4 }, new { a = 33, b = 44 }, new { a = 333, b = 4444 } };
            //BaseClass
            
            return AppConfiguration.GetValue("ConnectionStrings:conn");
        }

        #region 私有方法
        /// <summary>
        /// 通过用户信息生成token
        /// </summary>
        /// <param name="userInfo"></param>
        /// <returns></returns>
        private string GenerateToken(UserInfo userInfo)
        {
            var claims = new Claim[] {
                            new Claim(ClaimTypes.NameIdentifier, userInfo.cUser_Id),
                            new Claim(ClaimTypes.Name, userInfo.cUser_Name)
                        };
            var token = new JwtSecurityToken(
            issuer: CY_SystemConsts.TokenIssuer,
            audience: CY_SystemConsts.TokenAudience,
            claims: claims,
            notBefore: DateTime.Now,
            expires: DateTime.Now.AddDays(28),
            signingCredentials: new SigningCredentials(SecurityKey, SecurityAlgorithms.HmacSha256)
            );
            return new JwtSecurityTokenHandler().WriteToken(token); ;
        }
        #endregion
    }
}
