using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.DomainStandard
{
    /// <summary>
	/// StampOrder实体类
    /// 作者: C
    /// 时间: 2018-01-03 16:34:20
    /// </summary>
    [POCO(DbConnName = CY_SystemConsts.ConnectionString_conn, TableName = "sa_StampOrder")]
    public class StampOrderInfo
    {
        /// <summary>
        /// 承接单ID
        /// <summary>
        [Identity]
        public Guid? Guid_ID { get; set; }

        /// <summary>
        /// 承接单ID
        /// <summary>
        public int? ID { get; set; }

        /// <summary>
        /// 承接单号
        /// <summary>
        public string Code { get; set; }

        /// <summary>
        /// 承接类型
        /// <summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 刻章单位
        /// <summary>
        public string StampUnit { get; set; }

        /// <summary>
        /// 客户编码
        /// <summary>
        public string cCusCode { get; set; }

        /// <summary>
        /// 联系人编码
        /// <summary>
        public string cLinkCode { get; set; }

        /// <summary>
        /// 承接日期
        /// <summary>
        public DateTime? dDate { get; set; }

        /// <summary>
        /// 预交日期
        /// <summary>
        public DateTime? dPreDeliDate { get; set; }

        /// <summary>
        /// 承接总额
        /// <summary>
        public double? iTotalCost { get; set; }

        /// <summary>
        /// 开票
        /// <summary>
        public bool? IsInvoice { get; set; }

        /// <summary>
        /// 开票ID
        /// <summary>
        public int? InvoiceID { get; set; }

        /// <summary>
        /// 状态id
        /// <summary>
        public string Status { get; set; }

        /// <summary>
        /// 纸质单据号
        /// <summary>
        public string PrintCode { get; set; }

        /// <summary>
        /// 是否送货
        /// <summary>
        public bool? IsDeli { get; set; }

        /// <summary>
        /// 取章点
        /// <summary>
        public string DeliDept { get; set; }

        /// <summary>
        /// 许可证号
        /// <summary>
        public string LicenseNo { get; set; }

        /// <summary>
        /// 交货地点
        /// <summary>
        public string DeliAddress { get; set; }

        /// <summary>
        /// 原承接单号
        /// <summary>
        public string SourceCode { get; set; }

        /// <summary>
        /// 打印次数
        /// <summary>
        public int? iPrintCount { get; set; }

        /// <summary>
        /// 备注
        /// <summary>
        public string Remark { get; set; }

        /// <summary>
        /// 创建人
        /// <summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// 部门编码
        /// <summary>
        public string cDepCode { get; set; }

        /// <summary>
        /// 业务组编码
        /// <summary>
        public string cTeamCode { get; set; }

        /// <summary>
        /// 创建时间
        /// <summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// 修改人
        /// <summary>
        public string ModifiedBy { get; set; }

        /// <summary>
        /// 修改时间
        /// <summary>
        public DateTime? ModifyDate { get; set; }

        /// <summary>
        /// 是否已生成电子协议
        /// <summary>
        public bool? isElectronic { get; set; }

        /// <summary>
        /// VerificationCode属性
        /// <summary>
        public string VerificationCode { get; set; }

        /// <summary>
        /// CertificateCode属性
        /// <summary>
        public string CertificateCode { get; set; }

        /// <summary>
        /// 错章原因
        /// <summary>
        public string ErrorReason { get; set; }

        /// <summary>
        /// 扣款金额
        /// <summary>
        public double? ChargeAmount { get; set; }

        ///// <summary>
        ///// LastAccessTime属性
        ///// <summary>
        //public string LastAccessTime { get; set; }

        /// <summary>
        /// ZDWHZ属性
        /// <summary>
        public string ZDWHZ { get; set; }

        //额外属性
        public double? PaidCost { get; set; }
        public string cPsn_Name { get; set; }
        public string cDepName { get; set; }
        public string DigitalNum { get; set; }
        public string cCusName { get; set; }
        public string cContactName { get; set; }
        public string LinkTel { get; set; }
        public string cTeamName { get; set; }



    }
}

