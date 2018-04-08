using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.DomainStandard
{
    /// <summary>
	/// AllTaxInfos实体类
    /// 作者: Anton-PC
    /// 时间: 2018-02-26 15:47:35
    /// </summary>
    [POCO(DbConnName = CY_SystemConsts.ConnectionString_conn, TableName = "cy_AllTaxInfos")]
    public class AllTaxInfosInfo
    {
        /// <summary>
        /// cTeamCode属性
        /// <summary>
        public string cTeamCode { get; set; }

        /// <summary>
        /// IdentityNum属性
        /// <summary>
        public string IdentityNum { get; set; }


    }
}

