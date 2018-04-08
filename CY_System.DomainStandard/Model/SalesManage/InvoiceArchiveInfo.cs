using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.DomainStandard
{
    /// <summary>
	/// InvoiceArchive实体类
    /// 作者: C
    /// 时间: 2018-01-22 16:25:44
    /// </summary>
    [POCO(DbConnName = CY_SystemConsts.ConnectionString_conn, TableName = "sa_InvoiceArchive")]
    public class InvoiceArchiveInfo
    {
        /// <summary>
        /// 流水ID
        /// <summary>
        public int? ID { get; set; }

        /// <summary>
        /// 业务模块
        /// <summary>
        public string BName { get; set; }

        /// <summary>
        /// 开票金额
        /// <summary>
        public double? iInvoiceCost { get; set; }

        /// <summary>
        /// 开票单位
        /// <summary>
        public string UnitName { get; set; }

        /// <summary>
        /// 已开票
        /// <summary>
        public bool? IsInvoice { get; set; }

        /// <summary>
        /// 开单营业部
        /// <summary>
        public string cTeamCodeS { get; set; }

        /// <summary>
        /// 取票营业部
        /// <summary>
        public string cTeamCode { get; set; }

        /// <summary>
        /// 是否纸质发票
        /// <summary>
        public bool? isPaper { get; set; }

        /// <summary>
        /// 开票日期
        /// <summary>
        public DateTime? dDate { get; set; }

        /// <summary>
        /// 处理人
        /// <summary>
        public string Handler { get; set; }

        /// <summary>
        /// 备注
        /// <summary>
        public string Remark { get; set; }

        /// <summary>
        /// CAID属性
        /// <summary>
        public Guid? CAID { get; set; }

        /// <summary>
        /// 税号
        /// <summary>
        public string RegCode { get; set; }

        /// <summary>
        /// BusCode属性
        /// <summary>
        public string BusCode { get; set; }


    }
}

