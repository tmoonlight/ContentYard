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
    /// 时间：2015-06-09 09:44:35
    /// </summary>
    
    public class InvoiceNumSettingInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public InvoiceNumSettingInfo()
        {
            this.cDepCode = string.Empty;
            this.cTeamCode = string.Empty;
            this.CurState = TState.None;
        }

        /// <summary>
        /// 部门编号
        /// <summary>
        
        public string cDepCode { get; set; }

        /// <summary>
        /// 业务组编号
        /// <summary>
        
        public string cTeamCode { get; set; }

        /// <summary>
        /// 发票代码
        /// <summary>
        
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 起始发票号
        /// <summary>
        
        public string StartNum { get; set; }

        /// <summary>
        /// 终止发票号
        /// <summary>
        
        public string EndNum { get; set; }

        /// <summary>
        /// 当前发票号
        /// <summary>
        
        public string CurNum { get; set; }

        /// <summary>
        /// 数据行状态
        /// <summary>
        
        public TState CurState { get; set; }


    }
}

