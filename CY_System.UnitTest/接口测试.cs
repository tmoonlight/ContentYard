using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using CY_System.BLL.MigrateBLL;
using CY_System.Service.Dto;

namespace CY_System.UnitTest
{

    [TestClass]
    public class 接口测试
    {
        [TestMethod]
        public void 代码生成器测试()
        {
            var bll = OrderBLL.GetInstance();
            
            OrderDto dto = new OrderDto();
            Guid guid = new Guid("A7A17660-6AB5-4BF3-A892-07E344A7C210");
            var model = bll.SelectModel(guid);
            Debug.Print(bll.SelectModel(guid).OrderFrom);
            Debug.Print("返回:" + OrderBLL.GetInstance().Add(dto).ToString());
            Debug.Print("返回:"+ OrderBLL.GetInstance().Add(dto).ToString());
            //Assert.AreEqual()
        }
    }
}
