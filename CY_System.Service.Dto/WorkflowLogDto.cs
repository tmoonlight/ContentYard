using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.Service.Dto
{
    /// <summary>
	/// WorkflowLog数据传输实体类
    /// 作者: C
    /// 时间: 2018-01-08 17:55:46
    /// </summary>
    public class WorkflowLogDto
    {
        /// <summary>
        /// ID属性
        /// <summary>
        public Guid? ID { get; set; }

        /// <summary>
        /// InPort属性
        /// <summary>
        public int? InPort { get; set; }

        /// <summary>
        /// OutPort属性
        /// <summary>
        public int? OutPort { get; set; }

        /// <summary>
        /// FunModule属性
        /// <summary>
        public string FunModule { get; set; }

        /// <summary>
        /// cCode属性
        /// <summary>
        public string cCode { get; set; }

        /// <summary>
        /// Summary属性
        /// <summary>
        public string Summary { get; set; }

        /// <summary>
        /// StatusNum属性
        /// <summary>
        public string StatusNum { get; set; }

        /// <summary>
        /// StatusName属性
        /// <summary>
        public string StatusName { get; set; }

        /// <summary>
        /// Handler属性
        /// <summary>
        public string Handler { get; set; }

        /// <summary>
        /// NextHandler属性
        /// <summary>
        public string NextHandler { get; set; }

        /// <summary>
        /// dHandleDate属性
        /// <summary>
        public DateTime? dHandleDate { get; set; }

        /// <summary>
        /// Remark属性
        /// <summary>
        public string Remark { get; set; }


    }
}


