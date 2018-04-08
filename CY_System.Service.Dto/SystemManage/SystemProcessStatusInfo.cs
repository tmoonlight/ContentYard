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
    /// 时间：2017-10-12 11:19:47
    /// </summary>
    
    public class SystemProcessStatusInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public SystemProcessStatusInfo()
        {
            this.Id = Guid.NewGuid();
            this.CurState = TState.None;
        }

        /// <summary>
        /// 
        /// <summary>
        
        
        public Guid? Id { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        
        public string FunModule { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        
        public int? Status { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        
        public string StatusName { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        
        public string Remarks { get; set; }

        /// <summary>
        /// 数据行状态
        /// <summary>
        
        
        public TState CurState { get; set; }


    }
}

