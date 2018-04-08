using System;
using System.Collections.Generic;
using System.Text;

namespace CY_System.Service.Dto
{
    public class StampOrderAllDataDto
    {
        /// <summary>
        /// 上传状态(更新/新增)
        /// </summary>
        public int State { get; set; }
        /// <summary>
        /// 承接单
        /// </summary>
        public List<StampOrdersDto> StampOrderItems { get; set; }
        public StampOrderDto StampOrder { get; set; }
        public HiPersonDto Person { get; set; }
        public double CurPayCost { get; set; }
        public PayRecordsDto PayRecords { get; set; }
        public List<StampPropertiesDto> SpiList { get; set; }
        //public CY_System.Domain.hi_personInfo PersonInfo { get; set; }
    }
}
