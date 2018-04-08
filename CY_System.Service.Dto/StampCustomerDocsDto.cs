using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.Service.Dto
{
    /// <summary>
	/// StampCustomerDocs数据传输实体类
    /// 作者: C
    /// 时间: 2018-01-18 16:46:51
    /// </summary>
    public class StampCustomerDocsDto
    {
        /// <summary>
        /// id属性
        /// <summary>
        public Guid? id { get; set; }

        /// <summary>
        /// dcode属性
        /// <summary>
        public string dcode { get; set; }

        /// <summary>
        /// CreateDate属性
        /// <summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// ModifyDate属性
        /// <summary>
        public DateTime? ModifyDate { get; set; }

        /// <summary>
        /// remark属性
        /// <summary>
        public string remark { get; set; }

        /// <summary>
        /// dname属性
        /// <summary>
        public string dname { get; set; }

        /// <summary>
        /// status属性
        /// <summary>
        public string status { get; set; }

        /// <summary>
        /// ReturnDate属性
        /// <summary>
        public DateTime? ReturnDate { get; set; }

        /// <summary>
        /// DeleteDate属性
        /// <summary>
        public DateTime? DeleteDate { get; set; }

        /// <summary>
        /// sqr属性
        /// <summary>
        public string sqr { get; set; }

        /// <summary>
        /// ghr属性
        /// <summary>
        public string ghr { get; set; }

        /// <summary>
        /// zfr属性
        /// <summary>
        public string zfr { get; set; }


    }
}


