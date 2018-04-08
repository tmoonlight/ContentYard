using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.Service.Dto
{
    /// <summary>
    /// 该段代码由代码生成器自动生成
    /// 作者：田大伟
    /// 时间：2017-04-14 18:35:14
    /// </summary>
    
    public class SealCertificateCustomerDocsInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public SealCertificateCustomerDocsInfo()
        {
            this.id = null;
            this.CurState = TState.None;
        }

        /// <summary>
        /// 
        /// <summary>
        
        public Guid? id { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string dcode { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public DateTime? ModifyDate { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string remark { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string dname { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string status { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public DateTime? ReturnDate { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public DateTime? DeleteDate { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string sqr { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string ghr { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string zfr { get; set; }

        /// <summary>
        /// 数据行状态
        /// <summary>
        
        public TState CurState { get; set; }


    }
}

