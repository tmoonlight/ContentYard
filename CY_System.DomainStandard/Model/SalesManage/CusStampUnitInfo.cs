using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.DomainStandard
{
    /// <summary>
	/// CusStampUnit实体类
    /// 作者: C
    /// 时间: 2018-01-29 14:55:29
    /// </summary>
    [POCO(DbConnName = CY_SystemConsts.ConnectionString_conn, TableName = "sa_CusStampUnit")]
    public class CusStampUnitInfo
    {
        /// <summary>
        /// 流水ID
        /// <summary>
        public int? ID { get; set; }

        /// <summary>
        /// 客户编码
        /// <summary>
        public string cCusCode { get; set; }

        /// <summary>
        /// 刻章单位
        /// <summary>
        public string StampUnit { get; set; }


    }
}

