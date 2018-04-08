using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.Service.Dto
{
  
    /// <summary>
    /// 登录人
    /// </summary>
    public class HiPersonDto
    {
      
        /// <summary>
        /// 
        /// <summary>

        public string cPsn_Num { get; set; }

        /// <summary>
        /// 
        /// <summary>

        public string cPsn_Name { get; set; }

        /// <summary>
        /// 
        /// <summary>

        public string cPsn_NameEN { get; set; }

        /// <summary>
        /// 
        /// <summary>

        public string cDept_num { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public string cDepName { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public string rSex { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public string dBirthDate { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public string vCardNo { get; set; }

        /// <summary>
        /// 业务组
        /// </summary>
        public string cDutyclass { get; set; }

        /// <summary>
        /// 业务组名称
        /// </summary>
        public string cTeamName { get; set; }

        /// <summary>
        /// 业务组简称
        /// </summary>
        public string cTeamAbbName { get; set; }

        /// <summary>
        /// 是否是销售组
        /// </summary>
        public bool bSaleTeam { get; set; }

        /// <summary>
        /// 加急点
        /// </summary>
        public string cUrgentCode { get; set; }

        /// <summary>
        /// 加急点名称
        /// </summary>
        public string cUrgentName { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public string dLastDate { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public string cPsnMobilePhone { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public string cPsnOPhone { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public string cPsnInPhone { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public string cPsnEmail { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public string cFax { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public string rEmployState { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public string cpersonbarcode { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public string cPsnQQCode { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public string cPsnPostAddr { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public string cDepPostCode { get; set; }

        /// <summary>
        /// 
        /// <summary>
        public bool? bTakeTM { get; set; }

        /// <summary>
        /// 是否业务员
        /// <summary>
        public bool? bPsnPerson { get; set; }

        /// <summary>
        /// 是否营业员
        /// <summary>
        public bool? bpsnshop { get; set; }

        /// <summary>
        /// 数据行状态
        /// <summary>
        public TState CurState { get; set; }

    }
}

