using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CY_System.Service.Controllers
{
    /// <summary>
    /// 用户
    /// </summary>
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        ///// <summary>
        ///// 登录并返回Json Web Token
        ///// </summary>
        //[AllowAnonymous]
        //[HttpPost]
        //public string Login(string userName, string passWord)
        //{
        //    return "";
        //}
    }
}