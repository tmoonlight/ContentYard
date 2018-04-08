using System;
using System.Collections.Generic;
using System.Text;

namespace CY_System.Service.Dto
{
    /// <summary>
    /// 查询印章信息和客户,该实体用在报价单查询中
    /// </summary>
    public class StampOrdersAndCustomerDto
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string tName { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string tAddress { get; set; }

        /// <summary>
        /// 联系人 
        /// </summary>
        public string tContactorName { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        public string tContact { get; set; }

        /// <summary>
        /// QQEmail
        /// </summary>
        public string tQQEmail { get; set; }

        //public string CreateDate;
        /// <summary>
        /// 印章订单
        /// </summary>
        public List<StampOrdersDto> StampOrders { get; set; }
    }
}
