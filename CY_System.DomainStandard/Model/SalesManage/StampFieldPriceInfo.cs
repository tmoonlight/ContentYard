using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.DomainStandard
{
    /// <summary>
	/// StampFieldPrice实体类
    /// 作者: C
    /// 时间: 2018-01-25 18:35:22
    /// </summary>
    [POCO(DbConnName = CY_SystemConsts.ConnectionString_conn, TableName = "sa_StampFieldPrice")]
    public class StampFieldPriceInfo
    {
        /// <summary>
        /// Id属性
        /// <summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// cInvCode属性
        /// <summary>
        public string cInvCode { get; set; }

        /// <summary>
        /// 外市价格(湛江/肇庆/)
        /// <summary>
        public double? iUnitPrice1 { get; set; }

        /// <summary>
        /// 外市价格(云浮)
        /// <summary>
        public double? iUnitPrice2 { get; set; }

        /// <summary>
        /// 外市价格（河源）
        /// <summary>
        public double? iUnitPrice3 { get; set; }

        /// <summary>
        /// 外市价格（河源）
        /// <summary>
        public double? iUnitPrice4 { get; set; }

        /// <summary>
        /// EnableDate属性
        /// <summary>
        public DateTime? EnableDate { get; set; }

        /// <summary>
        /// DisableDate属性
        /// <summary>
        public DateTime? DisableDate { get; set; }

        /// <summary>
        /// Remarks属性
        /// <summary>
        public string Remarks { get; set; }


    }
}

