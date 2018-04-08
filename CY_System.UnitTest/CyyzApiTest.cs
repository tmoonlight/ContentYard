using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CY_System.Persistence.Mappers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CY_System.UnitTest
{
    [TestClass]
    public class CyyzApiTest
    {
        // private TestContext testContextInstance;
        [TestMethod]
        public void dsTest()
        {
           
            DigitalStamp ds = new DigitalStamp();
            //TestContext.
            Console.WriteLine((ds.IsExDZYZ("test")));
            //Debug.WriteLine("test debug");
           // ds.PostFunction();
        }
    }
}
