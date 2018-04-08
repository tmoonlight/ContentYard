using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CY_System.Service.Dto.SystemManage
{
    public class SVerInfo
    {
        public string ID { get; set; }
        public string CurVersion { get; set; }
        public string NewVersion { get; set; }
        public string Summary { get; set; }
        public string BakFileName { get; set; }
        public string CreateUser { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
