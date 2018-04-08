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
    /// 时间：2017-06-26 11:50:51
    /// </summary>
    
    public class InvoiceApplyInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public InvoiceApplyInfo()
        {
          
        }

        /// <summary>
        /// 
        /// <summary>
        
        public int? ID { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string Code { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string OrderType { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public int? Status { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string InvoiceType { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string InvoiceClass { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string OldTicketClass { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string UnitName { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string RegCode { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public decimal? InvocieCost { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string Bank { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string Address { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string Telephone { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string InvoiceUnitName { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public int? InvoiceID { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string InvoiceNO { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string BusCode { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string BusType { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string Remark1 { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string Remark2 { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string Remark3 { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string Remark4 { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string Remark5 { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string CreatedBy { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public DateTime? CreateDate { get; set; }

        ///// <summary>
        ///// 
        ///// <summary>
        //
        //public string Auditor1 { get; set; }

        ///// <summary>
        ///// 
        ///// <summary>
        //
        //public DateTime? AuditTime1 { get; set; }

        ///// <summary>
        ///// 
        ///// <summary>
        //
        //public string Auditor2 { get; set; }

        ///// <summary>
        ///// 
        ///// <summary>
        //
        //public DateTime? AuditTime2 { get; set; }

        ///// <summary>
        ///// 
        ///// <summary>
        //
        //public string Auditor3 { get; set; }

        ///// <summary>
        ///// 
        ///// <summary>
        //
        //public DateTime? AuditTime3 { get; set; }

        ///// <summary>
        ///// 
        ///// <summary>
        //
        //public string Auditor4 { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public DateTime? AuditTime4 { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string stamptime { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cTeamCode { get; set; }

        /// <summary>
        ///旧票回收
        /// <summary>
        
        public bool? RecycleInvoice { get; set; }

        /// <summary>
        ///冲红重开
        /// <summary>
        
        public bool? Reopen { get; set; }
    }
}

