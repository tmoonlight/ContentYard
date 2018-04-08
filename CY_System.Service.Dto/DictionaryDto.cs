using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.Service.Dto
{
    /// <summary>
	/// Dictionary数据传输实体类
    /// 作者: C
    /// 时间: 2018-01-17 19:42:37
    /// </summary>
    public class DictionaryDto
    {
        /// <summary>
        /// 节点ID
        /// <summary>
        public int? ID { get; set; }

        /// <summary>
        /// 父节点ID
        /// <summary>
        public int? PID { get; set; }

        /// <summary>
        /// 编码
        /// <summary>
        public string Code { get; set; }

        /// <summary>
        /// 名称
        /// <summary>
        public string Name { get; set; }

        /// <summary>
        /// 排序
        /// <summary>
        public int? Orders { get; set; }

        /// <summary>
        /// 是否已停用
        /// <summary>
        public bool? IsStop { get; set; }

        /// <summary>
        /// 备注
        /// <summary>
        public string Remark { get; set; }


    }
}


