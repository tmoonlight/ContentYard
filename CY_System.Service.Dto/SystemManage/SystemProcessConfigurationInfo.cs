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
    
    public class SystemProcessConfigurationInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public SystemProcessConfigurationInfo()
        {
            this.CurState = TState.None;
        }

        /// <summary>
        /// 
        /// <summary>
        
        
        public Guid Id { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        
        public string FunModule { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        
        public int? FromStatus { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        
        public string FromStatusName { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        
        public int? ToStatus { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        
        public string ToStatusName { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        
        public int? BackStatus { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        
        public string BackStatusName { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        
        public string ProcessName { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        
        public string Roles { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        
        public string RolesName { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        
        public string UserId { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        
        public bool? IsBegin { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        
        public bool? IsEnd { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        
        public string AdoptSQL { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        
        public string BackSQL { get; set; }

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

