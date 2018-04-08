using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.DomainStandard
{
    /// <summary>
	/// CRM_Customer实体类
    /// 作者: C
    /// 时间: 2018-01-18 16:35:35
    /// </summary>
    [POCO(DbConnName = CY_SystemConsts.ConnectionString_conn, TableName = "crm_customer")]
    public class CRM_CustomerInfo
    {
        /// <summary>
        /// customer_id属性
        /// <summary>
        public int? customer_id { get; set; }

        /// <summary>
        /// customer_name属性
        /// <summary>
        public string customer_name { get; set; }

        /// <summary>
        /// customer_name_short属性
        /// <summary>
        public string customer_name_short { get; set; }

        /// <summary>
        /// customer_number属性
        /// <summary>
        public string customer_number { get; set; }

        /// <summary>
        /// customer_type属性
        /// <summary>
        public int? customer_type { get; set; }

        /// <summary>
        /// address属性
        /// <summary>
        public string address { get; set; }

        /// <summary>
        /// postcode属性
        /// <summary>
        public string postcode { get; set; }

        /// <summary>
        /// website属性
        /// <summary>
        public string website { get; set; }

        /// <summary>
        /// customer_kind属性
        /// <summary>
        public int? customer_kind { get; set; }

        /// <summary>
        /// hot_type属性
        /// <summary>
        public int? hot_type { get; set; }

        /// <summary>
        /// importance_evaluate属性
        /// <summary>
        public string importance_evaluate { get; set; }

        /// <summary>
        /// credit_grade属性
        /// <summary>
        public int? credit_grade { get; set; }

        /// <summary>
        /// calling属性
        /// <summary>
        public int? calling { get; set; }

        /// <summary>
        /// relation_grade属性
        /// <summary>
        public int? relation_grade { get; set; }

        /// <summary>
        /// dimensions属性
        /// <summary>
        public int? dimensions { get; set; }

        /// <summary>
        /// source属性
        /// <summary>
        public int? source { get; set; }

        /// <summary>
        /// introduction属性
        /// <summary>
        public string introduction { get; set; }

        /// <summary>
        /// country属性
        /// <summary>
        public int? country { get; set; }

        /// <summary>
        /// province属性
        /// <summary>
        public int? province { get; set; }

        /// <summary>
        /// city属性
        /// <summary>
        public int? city { get; set; }

        /// <summary>
        /// remark属性
        /// <summary>
        public string remark { get; set; }

        /// <summary>
        /// creator属性
        /// <summary>
        public int? creator { get; set; }

        /// <summary>
        /// create_date属性
        /// <summary>
        public DateTime? create_date { get; set; }

        /// <summary>
        /// modifier属性
        /// <summary>
        public int? modifier { get; set; }

        /// <summary>
        /// modify_date属性
        /// <summary>
        public DateTime? modify_date { get; set; }

        /// <summary>
        /// opt_flag属性
        /// <summary>
        public int? opt_flag { get; set; }

        /// <summary>
        /// bank属性
        /// <summary>
        public string bank { get; set; }

        /// <summary>
        /// saleAudit属性
        /// <summary>
        public int? saleAudit { get; set; }


    }
}

