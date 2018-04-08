using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.DomainStandard
{
    /// <summary>
	/// StampQuote实体类
    /// 作者: C
    /// 时间: 2018-03-12 14:06:02
    /// </summary>
    [POCO(DbConnName = CY_SystemConsts.ConnectionString_conn, TableName = "sa_StampQuote")]
    public class StampQuoteInfo
    {
        /// <summary>
        /// 标识ID
        /// <summary>
        public int? ID { get; set; }

        /// <summary>
        /// fID属性
        /// <summary>
        public int? fID { get; set; }

        /// <summary>
        /// 主体公司名
        /// <summary>
        public string fName { get; set; }

        /// <summary>
        /// 主体地址
        /// <summary>
        public string fAddress { get; set; }

        /// <summary>
        /// 主体公司联系人姓名
        /// <summary>
        public string fContactorName { get; set; }

        /// <summary>
        /// 主体联系方式
        /// <summary>
        public string fContact { get; set; }

        /// <summary>
        /// 主体QQ/Email
        /// <summary>
        public string fQQEmail { get; set; }

        /// <summary>
        /// 客户名
        /// <summary>
        public string tName { get; set; }

        /// <summary>
        /// 客户地址
        /// <summary>
        public string tAddress { get; set; }

        /// <summary>
        /// 客户联系人姓名
        /// <summary>
        public string tContactorName1 { get; set; }

        /// <summary>
        /// 客户联系方式
        /// <summary>
        public string tContact { get; set; }

        /// <summary>
        /// 客户QQ/Email
        /// <summary>
        public string tQQEmail { get; set; }

        /// <summary>
        /// tID属性
        /// <summary>
        public int? tID { get; set; }

        /// <summary>
        /// 创建时间
        /// <summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// 创建用户
        /// <summary>
        public string CreateUser { get; set; }

        /// <summary>
        /// 修改时间
        /// <summary>
        public DateTime? LastUpdateDate { get; set; }

        /// <summary>
        /// IsAbandon属性
        /// <summary>
        public string IsAbandon { get; set; }

        /// <summary>
        /// LastUpdateUser属性
        /// <summary>
        public string LastUpdateUser { get; set; }

        /// <summary>
        /// Status属性
        /// <summary>
        public string Status { get; set; }


    }
}

