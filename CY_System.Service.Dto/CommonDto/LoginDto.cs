using System;
using System.Collections.Generic;
using System.Text;

namespace CY_System.Service.Dto
{
    public class LoginDto
    {
        /// <summary>
        /// 用户id
        /// </summary>
        public string cUser_Id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string cUser_Name { get; set; }

        /// <summary>
        /// 全名
        /// <summary>
        public string cPsn_Name { get; set; }

        ///// <summary>
        ///// 密码
        ///// <summary>
        //public string cPassword { get; set; }
        /// <summary>
        /// 数据行状态
        /// <summary>
        //public TState CurState { get; set; }

        /// <summary>
        /// 手机
        /// <summary>
        public string cPsnMobilePhone { get; set; }

        /// <summary>
        /// Json Web Token
        /// </summary>
        public string JWT { get; set; }

        /// <summary>
        /// 提示信息
        /// </summary>
        public string Message { get; set; }
    }
}
