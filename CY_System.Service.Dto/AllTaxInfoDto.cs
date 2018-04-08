using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.Service.Dto
{
    /// <summary>
	/// AllTaxInfo数据传输实体类
    /// 作者: Anton-PC
    /// 时间: 2018-02-26 15:47:35
    /// </summary>
    public class AllTaxInfoDto
    {
        /// <summary>
        /// 营业部编码
        /// <summary>
        public string cTeamCode { get; set; }

        /// <summary>
        /// appId属性
        /// <summary>
        public string appId { get; set; }

        /// <summary>
        /// 终端标识
        /// <summary>
        public string IdentitySign { get; set; }

        /// <summary>
        /// 纳税人识别号
        /// <summary>
        public string IdentityNum { get; set; }

        /// <summary>
        /// 纳税人
        /// <summary>
        public string TaxPayer { get; set; }

        /// <summary>
        /// 纳税人地址
        /// <summary>
        public string TaxAddress { get; set; }

        /// <summary>
        /// 纳税人电话
        /// <summary>
        public string TaxTelphone { get; set; }

        /// <summary>
        /// 银行账户
        /// <summary>
        public string BankAccount { get; set; }

        /// <summary>
        /// 税率
        /// <summary>
        public int? TaxRate { get; set; }

        /// <summary>
        /// 开票类别:0-不限;1-普票;2-专票
        /// <summary>
        public int? InvoceType { get; set; }

        /// <summary>
        /// 编码表版本号
        /// <summary>
        public string BMB_BBH { get; set; }

        /// <summary>
        /// 征税方式：0-普通征税，2-差额征税
        /// <summary>
        public string zsfs { get; set; }

        /// <summary>
        /// 商品编码
        /// <summary>
        public string spbm { get; set; }

        /// <summary>
        /// 优惠政策标识:0未使用，1使用
        /// <summary>
        public string yhzcbs { get; set; }

        /// <summary>
        /// 零税率标识:空代表正常税率,1 出口免税和其他免税优惠政策（免税）,2 不征增值税（不征税）,3 普通零税率（0%）
        /// <summary>
        public string lslbs { get; set; }

        /// <summary>
        /// 增值税特殊管理:如果yhzcbs为1时，此项必填
        /// <summary>
        public string zzstsgl { get; set; }

        /// <summary>
        /// InvoiceNumber属性
        /// <summary>
        public int? InvoiceNumber { get; set; }

        /// <summary>
        /// RealQuantity属性
        /// <summary>
        public int? RealQuantity { get; set; }


    }
}


