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
    
    public class UserFunctionsInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public UserFunctionsInfo()
        {
            this.User_ID = string.Empty;
            this.Function_ID = 0;
            this.CurState = TState.None;
        }

        /// <summary>
        /// 用户ID
        /// <summary>
        
        public string User_ID { get; set; }

        /// <summary>
        /// 功能ID
        /// <summary>
        
        public int? Function_ID { get; set; }

        /// <summary>
        /// 数据行状态
        /// <summary>
        
        public TState CurState { get; set; }


    }
}

