using System;
using System.Collections.Generic;
using System.Text;

namespace CY_System.DomainStandard
{

    /// <summary>
    /// Dictionary数据传输实体类
    /// 作者: C
    /// 时间: 2018-01-17 19:42:37
    /// </summary>
    public class StampOrderVerifyFilter
    {
        /// <summary>
        /// 是否加急
        /// </summary>
        public bool IsAgent { get; set; }

        /// <summary>
        /// 代码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        public string OrderType { get; set; }

        /// <summary>
        /// 客户名
        /// </summary>
        public string CusName { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 欠款
        /// </summary>
        public bool IsDebt { get; set; }

        /// <summary>
        /// 作废
        /// </summary>
        public bool ToVoid { get; set; }

        /// <summary>
        /// 部门
        /// </summary>
        public string DepCode { get; set; }

        /// <summary>
        /// 营业部名称
        /// </summary>
        public string TeamName { get; set; }

        /// <summary>
        /// 印章单位
        /// </summary>
        public string StampUnit { get; set; }

        /// <summary>
        /// 起始时间
        /// </summary>
        public DateTime? FromDate { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime? ToDate { get; set; }

        public string UserId { get; set; }
    }
}
