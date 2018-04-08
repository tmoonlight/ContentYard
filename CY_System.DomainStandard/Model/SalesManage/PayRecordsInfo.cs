using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.DomainStandard
{
    /// <summary>
	/// PayRecords实体类
    /// 作者: C
    /// 时间: 2018-01-22 15:49:01
    /// </summary>
    [POCO(DbConnName = CY_SystemConsts.ConnectionString_conn, TableName = "sa_PayRecords")]
    public class PayRecordsInfo
    {
        /// <summary>
        /// 流水ID
        /// <summary>
        public int? AutoID { get; set; }

        /// <summary>
        /// BName属性
        /// <summary>
        public string BName { get; set; }

        /// <summary>
        /// 主表ID
        /// <summary>
        public Guid? BID1 { get; set; }

        /// <summary>
        /// 主表ID
        /// <summary>
        public int? BID { get; set; }

        /// <summary>
        /// 行号
        /// <summary>
        public int? iRowNo { get; set; }

        /// <summary>
        /// 付款方式
        /// <summary>
        public string PayType { get; set; }

        /// <summary>
        /// 付款金额
        /// <summary>
        public double? iPayCost { get; set; }

        /// <summary>
        /// 收款人
        /// <summary>
        public string Handler { get; set; }

        /// <summary>
        /// 部门编码
        /// <summary>
        public string cDepCode { get; set; }

        /// <summary>
        /// 业务组编码
        /// <summary>
        public string cTeamCode { get; set; }

        /// <summary>
        /// 付款日期
        /// <summary>
        public DateTime? dPayDate { get; set; }

        /// <summary>
        /// Remark属性
        /// <summary>
        public string Remark { get; set; }


    }
}

