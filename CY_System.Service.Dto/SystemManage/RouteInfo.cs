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
    /// 时间：2015/12/25 16:50:10
    /// </summary>
    
    public class RouteInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public RouteInfo()
        {
            this.ID = 0;
            this.RName = string.Empty;
            this.CurState = TState.None;
        }

        /// <summary>
        /// 
        /// <summary>
        
        public int? ID { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string RName { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string lineNo { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string Owner { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string CreateBy { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public DateTime? CreateDate { get; set; }

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

