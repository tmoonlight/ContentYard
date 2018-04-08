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
    /// 时间：2016-03-23 11:38:23
    /// </summary>
    
    public class CY_VendorClassInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public CY_VendorClassInfo()
        {
            this.cVCCode = string.Empty;
            this.cVCName = string.Empty;
            this.iVCGrade = 1;
            this.bVCEnd = false;
        }

        /// <summary>
        /// 
        /// <summary>
        
        public string cVCCode { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cVCName { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public byte? iVCGrade { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public bool? bVCEnd { get; set; }


    }
}

