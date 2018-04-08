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
    /// 时间：2017-03-21 11:39:00
    /// </summary>
    
    public class SealCertificateContentInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public SealCertificateContentInfo()
        {
            this.ID = null;
            this.CurState = TState.None;
        }

        /// <summary>
        /// 
        /// <summary>
        
        public Guid? ID { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string CertificateCode { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string CusName { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string BusLicence { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string CorporateCard { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public bool? RegiCard { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string OperateCard { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public bool? AccountCard { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string PersonCertificate { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public bool? RegiForeCard { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string EnterpriseCertificate { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string OldSigNum { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public bool? BGDoc { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string Other { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string HandleType { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string LinkMan { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string LinkTel { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string LinkEmail { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string Handle { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string HandleOffice { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string EnterTel { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string PickYear { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string PickMonth { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string PickDay { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string TolPay { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string CurPay { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string UnPay { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string PayType { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string Status { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string CreateBy { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string VerificationCode { get; set; }

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
        
        public string ModifyBy { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public DateTime? ModifyDate { get; set; }


        /// <summary>
        /// 是否归还全部资料
        /// <summary>
        
        public bool? AllBack { get; set; }

        /// <summary>
        /// 数据行状态
        /// <summary>
        
        public TState CurState { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string Remark { get; set; }

        
        public string cCusCode { get; set; }

        
        public string UnitCus { get; set; }

        
        public string DeliDept { get; set; }


    }
}

