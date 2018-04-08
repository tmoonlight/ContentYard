using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.DomainStandard
{
    /// <summary>
	/// WorkflowSetting实体类
    /// 作者: C
    /// 时间: 2018-01-17 15:58:39
    /// </summary>
    [POCO(DbConnName = CY_SystemConsts.ConnectionString_conn, TableName = "ss_WorkflowSetting")]
    public class WorkflowSettingInfo
    {
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


    }
}

