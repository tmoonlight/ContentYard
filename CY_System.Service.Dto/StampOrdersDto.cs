using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.Service.Dto
{
    /// <summary>
	/// StampOrders数据传输实体类
    /// 作者: C
    /// 时间: 2018-01-08 16:42:56
    /// </summary>
    public class StampOrdersDto
    {
     

        /// <summary>
        /// GUID_AutoID属性
        /// <summary>
        public Guid? GUID_AutoID { get; set; }

        /// <summary>
        /// 流水ID
        /// <summary>
        public int? AutoID { get; set; }

        /// <summary>
        /// 主表ID
        /// <summary>
        public Guid? Guid_PID { get; set; }

        /// <summary>
        /// 主表ID
        /// <summary>
        public int? PID { get; set; }

        /// <summary>
        /// 商品名称
        /// <summary>
        public string GoodsName { get; set; }

        /// <summary>
        /// 存货编码
        /// <summary>
        public string cInvCode { get; set; }

        /// <summary>
        /// 存货名称
        /// <summary>
        public string cInvName { get; set; }

        /// <summary>
        /// 印章类型
        /// <summary>
        public string StampType { get; set; }

        /// <summary>
        /// 规格型号
        /// <summary>
        public string cInvStd { get; set; }

        /// <summary>
        /// 数码号
        /// <summary>
        public string DigitalNum { get; set; }

        /// <summary>
        /// 中心图案
        /// <summary>
        public string CenterPattern { get; set; }

        /// <summary>
        /// 饰标
        /// <summary>
        public string DecorationSign { get; set; }

        /// <summary>
        /// 颜色
        /// <summary>
        public string cInvDefine1 { get; set; }

        /// <summary>
        /// 长度
        /// <summary>
        public string cInvDefine2 { get; set; }

        /// <summary>
        /// 宽度
        /// <summary>
        public string cInvDefine3 { get; set; }

        /// <summary>
        /// 形状
        /// <summary>
        public string cInvDefine4 { get; set; }

        /// <summary>
        /// 章面
        /// <summary>
        public string cInvDefine5 { get; set; }

        /// <summary>
        /// 边宽
        /// <summary>
        public double? BorderWidth { get; set; }

        /// <summary>
        /// 印油
        /// <summary>
        public string StampInk { get; set; }

        /// <summary>
        /// 数量
        /// <summary>
        public double? iQuantity { get; set; }

        /// <summary>
        /// 标准价
        /// <summary>
        public double? iStdPrice { get; set; }

        /// <summary>
        /// 折扣
        /// <summary>
        public double? Discount { get; set; }

        /// <summary>
        /// 成交价
        /// <summary>
        public double? iUnitPrice { get; set; }

        /// <summary>
        /// 总价
        /// <summary>
        public double? iCost { get; set; }

        /// <summary>
        /// 明细状态
        /// <summary>
        public string Status { get; set; }

        /// <summary>
        /// 印章样式
        /// <summary>
        public string StampStyle { get; set; }

        /// <summary>
        /// StyleRemark属性
        /// <summary>
        public string StyleRemark { get; set; }

        /// <summary>
        /// 交货级别
        /// <summary>
        public string DeliLevel { get; set; }

        /// <summary>
        /// 加急点
        /// <summary>
        public string UrgentPoint { get; set; }

        /// <summary>
        /// 加急点编码
        /// <summary>
        public string cUrgentCode { get; set; }

        /// <summary>
        /// 行号
        /// <summary>
        public int? RowNo { get; set; }

        /// <summary>
        /// 是否送货
        /// <summary>
        public bool? IsDeli { get; set; }

        /// <summary>
        /// 取章点
        /// <summary>
        public string DeliDept { get; set; }

        /// <summary>
        /// 交货地点
        /// <summary>
        public string DeliAddress { get; set; }

        /// <summary>
        /// 0未质检    1 已质检（合格） 2  已质检（不合格）
        /// <summary>
        public int? IsChecked { get; set; }

        /// <summary>
        /// 排版状态
        /// <summary>
        public string LayoutStatus { get; set; }

        /// <summary>
        /// 排版人
        /// <summary>
        public string Layouter { get; set; }

        /// <summary>
        /// 排版时间
        /// <summary>
        public DateTime? dLayoutDate { get; set; }

        /// <summary>
        /// 备注
        /// <summary>
        public string Remark { get; set; }

        /// <summary>
        /// IsAllot属性
        /// <summary>
        public int? IsAllot { get; set; }

        /// <summary>
        /// IsScan属性
        /// <summary>
        public int? IsScan { get; set; }

        /// <summary>
        /// 条形码
        /// <summary>
        public string BarCode { get; set; }

        /// <summary>
        /// 数码
        /// <summary>
        public bool? IsDigital { get; set; }

        /// <summary>
        /// 防伪线
        /// <summary>
        public bool? IsSecurityLine { get; set; }

        /// <summary>
        /// 防伪码
        /// <summary>
        public bool? IsSecurityCode { get; set; }

        /// <summary>
        /// 是否必须审核
        /// <summary>
        public bool? IsVerify { get; set; }

        /// <summary>
        /// 来源ID
        /// <summary>
        public int? S_AutoID { get; set; }

        /// <summary>
        /// ChipID属性
        /// <summary>
        public string ChipID { get; set; }

        /// <summary>
        /// LastAccessTime属性
        /// <summary>
        public string LastAccessTime { get; set; }

        /// <summary>
        /// IsStampTemplate属性
        /// <summary>
        public bool? IsStampTemplate { get; set; }

        /// <summary>
        /// SCL属性
        /// <summary>
        public string SCL { get; set; }

        /// <summary>
        /// ZDWHZ属性
        /// <summary>
        public string ZDWHZ { get; set; }
        public string cInvCCode { get; set; }
        
        //临时属性
        public string cInvCName { get; set; }

        /// <summary>
        /// 自定义属性7
        /// </summary>
        public string cInvDefine7 { get; set; }
        public string GuidID { get; set; }
        public string ZZID { get; set; }
        /// <summary>
        /// 一照一码
        /// </summary>
        public string szZid { get; set; }

        /// <summary>
        /// 数据行状态
        /// </summary>
        public TState CurState { get; set; }
        public string S_Status { get; set; }
    }
}


