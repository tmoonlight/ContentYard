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
    /// 时间：2015-06-11 17:19:28
    /// </summary>
    
    public class WorkflowLogInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public WorkflowLogInfo()
        {
            this.ID = 0;
            this.StatusNum = string.Empty;
            this.StatusName = string.Empty;
            this.Handler = string.Empty;
            this.dHandleDate = DateTime.Now;
            this.CurState = TState.None;
        }

        /// <summary>
        /// 流水ID
        /// <summary>
        
        public int? ID { get; set; }

        /// <summary>
        /// 入口流程编号
        /// <summary>
        
        public int? InPort { get; set; }

        /// <summary>
        /// 出口流程编号
        /// <summary>
        
        public int? OutPort { get; set; }

        /// <summary>
        /// 业务模块
        /// <summary>
        
        public string FunModule { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        
        public string Summary { get; set; }

        /// <summary>
        /// 单据编号
        /// <summary>
        
        public string cCode { get; set; }

        /// <summary>
        /// 状态编号
        /// <summary>
        
        public string StatusNum { get; set; }

        /// <summary>
        /// 状态
        /// <summary>
        
        public string StatusName { get; set; }

        /// <summary>
        /// 处理人
        /// <summary>
        
        public string Handler { get; set; }

        /// <summary>
        /// 处理人
        /// <summary>
        
        public string HandlerName { get; set; }

        /// <summary>
        /// 下一处理人
        /// <summary>
        
        public string NextHandler { get; set; }

        /// <summary>
        /// 下一处理人
        /// <summary>
        
        public string NextHandlerName { get; set; }


        /// <summary>
        /// 处理日期
        /// <summary>
        
        public DateTime? dHandleDate { get; set; }

        /// <summary>
        /// 备注
        /// <summary>
        
        public string Remark { get; set; }

        /// <summary>
        /// 数据行状态
        /// <summary>
        
        public TState CurState { get; set; }


    }
}

