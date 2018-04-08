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
    /// 时间：2015/12/28 9:23:14
    /// </summary>
    
    public class TeamRouteInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public TeamRouteInfo()
        {
            this.ID = 0;
            this.TeamCode = string.Empty;
            this.RouteID = 0;
            this.CurState = TState.None;
        }

        /// <summary>
        /// 
        /// <summary>
        
        public int? ID { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string TeamCode { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public int? RouteID { get; set; }

        /// <summary>
        /// 数据行状态
        /// <summary>
        
        public TState CurState { get; set; }


    }
}

