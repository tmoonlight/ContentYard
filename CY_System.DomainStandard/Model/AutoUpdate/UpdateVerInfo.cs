using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.DomainStandard
{
    /// <summary>
	/// 升级版本记录实体类
    /// 作者: F
    /// 时间: 2018-01-15 16:34:20
    /// </summary>
    [POCO(DbConnName = CY_SystemConsts.ConnectionString_conn, TableName = "tb_UpdateVer")]
    public class UpdateVerInfo
    {
        /// <summary>
        /// ID
        /// <summary>
        public int ID { get; set; }

        /// <summary>
        /// 版本号
        /// <summary>
        public string Ver { get; set; }

        /// <summary>
        /// 更新包名
        /// <summary>
        public string UpdatePackName { get; set; }

        /// <summary>
        /// 更新时间
        /// <summary>
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 标识
        /// <summary>
        public int Flag { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}

