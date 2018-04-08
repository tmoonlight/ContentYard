using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.Service.Dto
{
    /// <summary>
    /// 该段代码由代码生成器自动生成
    /// 作者：田大伟
    /// 时间：2015-06-18 09:21:46
    /// </summary>
    
    public class LoginLogInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public LoginLogInfo()
        {
            this.ID = 0;
            this.cUser_Name = string.Empty;
            this.cDepCode = string.Empty;
            this.dLoginTime = DateTime.Now;
            this.CurState = TState.None;
        }

        /// <summary>
        /// 自动生成流水ID
        /// <summary>
        
        public int? ID { get; set; }

        /// <summary>
        /// 用户
        /// <summary>
        
        public string cUser_Name { get; set; }

        /// <summary>
        /// 用户
        /// <summary>
        
        public string cPsn_Name { get; set; }

        /// <summary>
        /// 部门
        /// <summary>
        
        public string cDepCode { get; set; }

        /// <summary>
        /// 部门
        /// <summary>
        
        public string cDepName { get; set; }

        /// <summary>
        /// 业务组
        /// <summary>
        
        public string cTeamCode { get; set; }

        /// <summary>
        /// 业务组
        /// <summary>
        
        public string cTeamName { get; set; }

        /// <summary>
        /// 登陆时间
        /// <summary>
        
        public DateTime? dLoginTime { get; set; }

        /// <summary>
        /// 退出时间
        /// <summary>
        
        public DateTime? dExitTime { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string OtherInfo { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string Remark { get; set; }

        /// <summary>
        /// 数据行状态
        /// <summary>
        
        public TState CurState { get; set; }


    }
}

