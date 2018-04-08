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
    /// 时间：2015-04-20 17:33:05
    /// </summary>
    
    public class UserInfoDto
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public UserInfoDto()
        {
            this.cUser_Id = string.Empty;
            this.CurState = TState.None;
            this.cPsnMobilePhone = "";
        }

        /// <summary>
        /// 
        /// <summary>
        
        public string cUser_Id { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cUser_Name { get; set; }

        /// <summary>
        /// 全名
        /// <summary>
        
        public string cPsn_Name { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cPassword { get; set; }

        /// <summary>
        /// 数据行状态
        /// <summary>
        
        public TState CurState { get; set; }

        /// <summary>
        /// 手机
        /// <summary>
        
        public string cPsnMobilePhone { get; set; }

    }
}

