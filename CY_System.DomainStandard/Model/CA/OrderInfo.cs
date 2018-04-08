using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.DomainStandard
{
    /// <summary>
    /// 该段代码由代码生成器自动生成
    /// 时间：2016/8/30 10:10:04
    /// </summary>
    [POCO(DbConnName = CY_SystemConsts.ConnectionString_conn_ca, TableName = "ca_Order")]
    public class OrderInfo: IAggregateRoot
    {
        
        [Identity]
        public Guid? ID { get; set; }

       
        public string CACode { get; set; }

       
        public Guid? Cus_ID { get; set; }

      
        public string Status { get; set; }

     
        public string OrderFrom { get; set; }

      
        public string HandleType { get; set; }

       
        public string cCusCode { get; set; }

      
        public string cContactCode { get; set; }

      
        public string CusName { get; set; }

    
        public string LinkTel { get; set; }

       
        public string Linkman { get; set; }

        public string PayType { get; set; }

     
        public bool IsCurPay { get; set; }

        
        public double? CurPayCost { get; set; }

       
        public double? iTotalCost { get; set; }

      
        public int? CusDataType { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public bool? IsInvoice { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public Guid? InvoiceID { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string Remark { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string CreatedBy { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cDepCode { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cTeamCode { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string ModifiedBy { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public DateTime? ModifyDate { get; set; }

     
    }
}

