//using Microsoft.AspNetCore.Http;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Claims;
//using System.Threading.Tasks;

//namespace CY_System.Service.Extensions
//{
//    /// <summary>
//    /// 角色权限扩展类
//    /// </summary>
//    public class IdentityExtensions
//    {

//        public void GetUserClaim(string key)
//        {
//            var identity = HttpContext..Identity as ClaimsIdentity;
//            if (identity != null)
//            {
//                IEnumerable<Claim> claims = identity.Claims;
//                // or
//                identity.FindFirst("ClaimName").Value;
                
//            }

//        }
//    }
//}
