using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.Service.Dto
{
    /// <summary>
	/// FileTansfer数据传输实体类
    /// 作者: C
    /// 时间: 2018-01-17 15:11:50
    /// </summary>
    public class FileTansferDto
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
        /// 业务ID
        /// <summary>
        public int? BID { get; set; }

        /// <summary>
        /// 文件原名
        /// <summary>
        public string OrgName { get; set; }

        /// <summary>
        /// 保存名
        /// <summary>
        public string SaveName { get; set; }

        /// <summary>
        /// 操作人
        /// <summary>
        public string Operator { get; set; }

        /// <summary>
        /// 操作日期
        /// <summary>
        public DateTime? dDate { get; set; }

        /// <summary>
        /// cCode属性
        /// <summary>
        public string cCode { get; set; }
        public string GuidBID { get; set; }
        public TState CurState { get; set; }
    }
}


