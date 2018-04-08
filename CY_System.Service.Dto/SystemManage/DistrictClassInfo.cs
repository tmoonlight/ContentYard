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
    /// 时间：2015-04-16 14:48:54
    /// </summary>
    
    public class DistrictClassInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public DistrictClassInfo()
        {
            this.cDCCode = string.Empty;
            this.cDCName = string.Empty;
            this.iDCGrade = 1;
            this.bDCEnd = false;
        }

        /// <summary>
        /// 地区编码
        /// <summary>
        
        public string cDCCode { get; set; }

        /// <summary>
        /// 地区名称
        /// <summary>
        
        public string cDCName { get; set; }

        /// <summary>
        /// 地区简称
        /// <summary>
        
        public string cDCAbbName { get; set; }

        /// <summary>
        /// 编码级次
        /// <summary>
        
        public byte? iDCGrade { get; set; }

        /// <summary>
        /// 是否末级
        /// <summary>
        
        public bool? bDCEnd { get; set; }

    }
}

