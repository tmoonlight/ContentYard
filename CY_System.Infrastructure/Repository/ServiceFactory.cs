using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CY_System.Infrastructure
{
    public class ServiceFactory
    {
        private static ServiceFactory _instance = new ServiceFactory();

        public static ServiceFactory GetInstance()
        {
            return _instance;
        }

    }
}
