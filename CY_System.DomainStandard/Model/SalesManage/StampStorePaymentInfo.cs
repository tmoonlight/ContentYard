using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.DomainStandard
{
    /// <summary>
	/// StampStorePayment实体类
    /// 作者: C
    /// 时间: 2018-01-12 11:55:24
    /// </summary>
    [POCO(DbConnName = CY_SystemConsts.ConnectionString_conn, TableName = "sa_StampStorePayment")]
    public class StampStorePaymentInfo
    {
        /// <summary>
        /// ID属性
        /// <summary>
        public int? ID { get; set; }

        /// <summary>
        /// cCode属性
        /// <summary>
        public string cCode { get; set; }

        /// <summary>
        /// cDepCode属性
        /// <summary>
        public string cDepCode { get; set; }

        /// <summary>
        /// cTeamCode属性
        /// <summary>
        public string cTeamCode { get; set; }

        /// <summary>
        /// CreatedPerson属性
        /// <summary>
        public string CreatedPerson { get; set; }

        /// <summary>
        /// CreateDate属性
        /// <summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// CreateTime属性
        /// <summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// ModifyPserson属性
        /// <summary>
        public string ModifyPserson { get; set; }

        /// <summary>
        /// ModifyTime属性
        /// <summary>
        public DateTime? ModifyTime { get; set; }

        /// <summary>
        /// VerifyPerson属性
        /// <summary>
        public string VerifyPerson { get; set; }

        /// <summary>
        /// VerifyTime属性
        /// <summary>
        public DateTime? VerifyTime { get; set; }

        /// <summary>
        /// State属性
        /// <summary>
        public int? State { get; set; }

        /// <summary>
        /// Remark属性
        /// <summary>
        public string Remark { get; set; }

        /// <summary>
        /// AccountRemark属性
        /// <summary>
        public string AccountRemark { get; set; }


    }
}

