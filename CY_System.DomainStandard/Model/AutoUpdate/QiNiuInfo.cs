using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.DomainStandard
{
    /// <summary>
	/// QiNiu实体类
    /// 作者: F
    /// 时间: 2018-01-15 16:34:20
    /// </summary>
    [POCO(DbConnName = CY_SystemConsts.ConnectionString_conn, TableName = "tb_QiNiu")]
    public class QiNiuInfo
    {
        /// <summary>
        /// ID
        /// <summary>
        public int ID { get; set; }

        /// <summary>
        /// AccessKey
        /// <summary>
        public string AccessKey { get; set; }

        /// <summary>
        /// SecretKey
        /// <summary>
        public string SecretKey { get; set; }

        /// <summary>
        /// 七牛命名空间
        /// <summary>
        public string Bucket { get; set; }

        /// <summary>
        /// 空间url
        /// <summary>
        public string Domain { get; set; }

        
    }
}

