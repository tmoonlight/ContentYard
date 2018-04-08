using System;
using System.Collections.Generic;
using System.Text;

namespace CY_System.DomainStandard
{
    public class OrderInfoWithOrderCount
    {
        private OrderInfo orderinfo;
        private int itemCount;

        public OrderInfo Orderinfo { get => orderinfo; set => orderinfo = value; }
        public int ItemCount { get => itemCount; set => itemCount = value; }
    }
}
