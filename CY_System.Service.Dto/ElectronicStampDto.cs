using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.Service.Dto
{
    /// <summary>
	/// ElectronicStamp数据传输实体类
    /// 作者: C
    /// 时间: 2018-01-22 15:55:28
    /// </summary>
    public class ElectronicStampDto
    {
        /// <summary>
        /// 证书唯一标识:签名或加密证书唯一标识
        /// <summary>
        public string oid { get; set; }

        /// <summary>
        /// 签名证书:签名证书Base64值
        /// <summary>
        public string signCert { get; set; }

        /// <summary>
        /// 加密证书:加密证书Base64值
        /// <summary>
        public string encryptCert { get; set; }

        /// <summary>
        /// 印章编码
        /// <summary>
        public string signCode { get; set; }

        /// <summary>
        /// 续期年数:0为不购买续期服务（默认使用1个月），非零时为购买年数
        /// <summary>
        public int? renewalYears { get; set; }

        /// <summary>
        /// 赠送年数
        /// <summary>
        public int? promotionYears { get; set; }

        /// <summary>
        /// 优惠活动类型:00,无优惠活动;01,xx年xx月xx日前免费送1年;02,折扣优惠
        /// <summary>
        public string preferentialType { get; set; }

        /// <summary>
        /// 总共续期年数:此字段年数为加上优惠活动后年数总数
        /// <summary>
        public int? totalRenewalYears { get; set; }

        /// <summary>
        /// 续期费用:Decimal(10,2),续期所交费用
        /// <summary>
        public double? renewalFee { get; set; }

        /// <summary>
        /// 有效期开始日期:电子印章有效期开始时间,格式为 yyyy-MM-dd
        /// <summary>
        public string validityStartDate { get; set; }

        /// <summary>
        /// 有效期结束日期:电子印章有效期结束时间,格式为 yyyy-MM-dd
        /// <summary>
        public string validityEndDate { get; set; }

        /// <summary>
        /// 返回结果代码
        /// <summary>
        public string statusCode { get; set; }

        /// <summary>
        /// 返回结果信息
        /// <summary>
        public string responseMsg { get; set; }

        /// <summary>
        /// 系统操作时间
        /// <summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// omid属性
        /// <summary>
        public Guid? omid { get; set; }

        /// <summary>
        /// bizType属性
        /// <summary>
        public string bizType { get; set; }

        /// <summary>
        /// oldOid属性
        /// <summary>
        public string oldOid { get; set; }

        /// <summary>
        /// orgCode属性
        /// <summary>
        public string orgCode { get; set; }


    }
}


