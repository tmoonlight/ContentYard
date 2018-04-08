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
    /// 时间：2017-03-03 10:55:50
    /// </summary>
    
    public class CY_VendorInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public CY_VendorInfo()
        {
            this.cVenCode = string.Empty;
            this.cVenAbbName = string.Empty;
            this.bVenTax = false;
            this.bLicenceDate = false;
            this.bBusinessDate = false;
            this.bProxyDate = false;
            this.bPassGMP = false;
            this.bVenCargo = false;
            this.bProxyForeign = false;
            this.bVenService = false;
            this.iVenGSPType = 0;
            this.bVenOverseas = false;
            this.bVenAccPeriodMng = false;
            this.bVenHomeBranch = false;
            this.dVenCreateDatetime = DateTime.Now;
        }

        /// <summary>
        /// 
        /// <summary>
        
        public string cVenCode { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cVenName { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cVenAbbName { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cVenAddress { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cVenPerson { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cVenPhone { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cVenFax { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public DateTime? dEndDate { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cVenHand { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cVCCode { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cDCCode { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public DateTime? dVenDevDate { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public double? iVenDisRate { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public double? iVenCreLine { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public int iVenCreDate { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cVenHeadCode { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public int iFrequency { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public bool? bVenTax { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cCreatePerson { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cModifyPerson { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public DateTime? dModifyDate { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public int iGradeABC { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public bool? bLicenceDate { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public bool? bBusinessDate { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public bool? bProxyDate { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public bool? bPassGMP { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public bool? bVenCargo { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public bool? bProxyForeign { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public bool? bVenService { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cVenExch_name { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public int iVenGSPType { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public int iVenGSPAuth { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public bool? bVenOverseas { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public bool? bVenAccPeriodMng { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public bool? bVenHomeBranch { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public DateTime? dVenCreateDatetime { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public bool? bIsVenAttachFile { get; set; }


    }
}

