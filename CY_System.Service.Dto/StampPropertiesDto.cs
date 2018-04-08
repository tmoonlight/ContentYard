using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.Service.Dto
{
    /// <summary>
	/// StampProperties数据传输实体类
    /// 作者: C
    /// 时间: 2018-01-17 15:11:50
    /// </summary>
    public class StampPropertiesDto
    {
        /// <summary>
        /// 流水ID
        /// <summary>
        public int? AutoID { get; set; }

        /// <summary>
        /// 主表ID
        /// <summary>
        public int? PID { get; set; }

        /// <summary>
        /// 序号
        /// <summary>
        public int? RowNo { get; set; }

        /// <summary>
        /// 章面内容
        /// <summary>
        public string StampContent { get; set; }

        /// <summary>
        /// 字体
        /// <summary>
        public string FontStyle { get; set; }

        /// <summary>
        /// 备注
        /// <summary>
        public string Remark { get; set; }

        //额外属性
        public string GuidPID { get; set; }
        public TState CurState { get; set; }
    }
}


