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
    /// 时间：2015-06-10 17:54:38
    /// </summary>
    
    public class WorkflowSettingInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public WorkflowSettingInfo()
        {
            this.ID = 0;
            this.Orders = 0;
            this.FunModule = string.Empty;
            this.StatusNum = string.Empty;
            this.StatusName = string.Empty;
            this.NextOrders = 0;
            this.GoOrders = 0;
            this.Role_ID = 0;
            this.IsCheckPerson = false;
            this.WarningDays = 0;
            this.CurState = TState.None;
        }

        /// <summary>
        /// 自动生成流水ID
        /// <summary>
        
        public int? ID { get; set; }

        /// <summary>
        /// 执行顺序
        /// <summary>
        
        public int? Orders { get; set; }

        /// <summary>
        /// 功能模块
        /// <summary>
        
        public string FunModule { get; set; }

        /// <summary>
        /// 状态编号
        /// <summary>
        
        public string StatusNum { get; set; }

        /// <summary>
        /// 状态名称
        /// <summary>
        
        public string StatusName { get; set; }

        /// <summary>
        /// 下一流程
        /// <summary>
        
        public int? NextOrders { get; set; }

        /// <summary>
        /// 流程跳转条件
        /// <summary>
        
        public string Condition { get; set; }

        /// <summary>
        /// 跳转流程
        /// <summary>
        
        public int? GoOrders { get; set; }

        /// <summary>
        /// 角色ID
        /// <summary>
        
        public int? Role_ID { get; set; }

        /// <summary>
        /// 角色
        /// <summary>
        
        public string Role_Name { get; set; }

        /// <summary>
        /// 选择审核人
        /// <summary>
        
        public bool? IsCheckPerson { get; set; }

        /// <summary>
        /// 预警天数
        /// <summary>
        
        public int? WarningDays { get; set; }

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

