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
    /// 时间：2015-04-21 10:36:38
    /// </summary>
    
    public class UserRolesInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public UserRolesInfo()
        {
            this.User_ID = string.Empty;
            this.Role_ID = 0;
            this.cPsn_Name = string.Empty;
            this.CurState = TState.None;
        }

        /// <summary>
        /// 用户ID
        /// <summary>
        
        public string User_ID { get; set; }

        /// <summary>
        /// 用户
        /// <summary>
        
        public string cPsn_Name { get; set; }

        /// <summary>
        /// 角色ID
        /// <summary>
        
        public int? Role_ID { get; set; }

        /// <summary>
        /// 角色名称
        /// <summary>
        
        public string Role_Name { get; set; }

        /// <summary>
        /// 数据行状态
        /// <summary>
        
        public TState CurState { get; set; }


    }
}

