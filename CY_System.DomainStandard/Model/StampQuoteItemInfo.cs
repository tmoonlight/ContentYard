using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.DomainStandard
{
    /// <summary>
	/// StampQuoteItem实体类
    /// 作者: C
    /// 时间: 2018-03-12 16:34:21
    /// </summary>
    [POCO(DbConnName = CY_SystemConsts.ConnectionString_conn, TableName = "sa_StampQuoteItem")]
    public class StampQuoteItemInfo
    {
        /// <summary>
        /// ID属性
        /// <summary>
        public int? ID { get; set; }

        /// <summary>
        /// StampQuoteID属性
        /// <summary>
        public int? StampQuoteID { get; set; }

        /// <summary>
        /// OrderNum属性
        /// <summary>
        public int? OrderNum { get; set; }

        /// <summary>
        /// StampOrdersID属性
        /// <summary>
        public int? StampOrdersID { get; set; }

        /// <summary>
        /// StampMaterial属性
        /// <summary>
        public string StampMaterial { get; set; }

        /// <summary>
        /// cInvStd属性
        /// <summary>
        public string cInvStd { get; set; }

        /// <summary>
        /// iQuality属性
        /// <summary>
        public double? iQuality { get; set; }

        /// <summary>
        /// iUnitPrice属性
        /// <summary>
        public double? iUnitPrice { get; set; }

        /// <summary>
        /// CreateDate属性
        /// <summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// cInvName属性
        /// <summary>
        public string cInvName { get; set; }


    }
}

