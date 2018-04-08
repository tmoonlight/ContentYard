using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.DomainStandard
{
    /// <summary>
	/// StampProperties实体类
    /// 作者: C
    /// 时间: 2018-01-17 15:11:50
    /// </summary>
    [POCO(DbConnName = CY_SystemConsts.ConnectionString_conn, TableName = "sa_StampProperties")]
    public class StampPropertiesInfo
    {
        [Identity]
        /// <summary>
        /// 流水ID
        /// <summary>
        public int? AutoID { get; set; }

        /// <summary>
        /// 主表ID
        /// <summary>
        public int? PID { get; set; }

        /// <summary>
        /// 序号
        /// <summary>
        public int? RowNo { get; set; }

        /// <summary>
        /// 章面内容
        /// <summary>
        public string StampContent { get; set; }

        /// <summary>
        /// 字体
        /// <summary>
        public string FontStyle { get; set; }

        /// <summary>
        /// 备注
        /// <summary>
        public string Remark { get; set; }


    }
}

