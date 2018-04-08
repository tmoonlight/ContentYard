using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.DomainStandard
{
    /// <summary>
	/// Department实体类
    /// 作者: C
    /// 时间: 2018-01-22 17:17:26
    /// </summary>
    [POCO(DbConnName = CY_SystemConsts.ConnectionString_conn, TableName = "Department")]
    public class DepartmentInfo
    {
        /// <summary>
        /// cDepCode属性
        /// <summary>
        public string cDepCode { get; set; }

        /// <summary>
        /// bDepEnd属性
        /// <summary>
        public bool? bDepEnd { get; set; }

        /// <summary>
        /// cDepName属性
        /// <summary>
        public string cDepName { get; set; }

        /// <summary>
        /// iDepGrade属性
        /// <summary>
        public byte? iDepGrade { get; set; }

        /// <summary>
        /// cDepPerson属性
        /// <summary>
        public string cDepPerson { get; set; }

        /// <summary>
        /// cDepProp属性
        /// <summary>
        public string cDepProp { get; set; }

        /// <summary>
        /// cDepPhone属性
        /// <summary>
        public string cDepPhone { get; set; }

        /// <summary>
        /// cDepAddress属性
        /// <summary>
        public string cDepAddress { get; set; }

        /// <summary>
        /// cDepMemo属性
        /// <summary>
        public string cDepMemo { get; set; }

        /// <summary>
        /// iCreLine属性
        /// <summary>
        public double? iCreLine { get; set; }

        /// <summary>
        /// cCreGrade属性
        /// <summary>
        public string cCreGrade { get; set; }

        /// <summary>
        /// iCreDate属性
        /// <summary>
        public int? iCreDate { get; set; }

        /// <summary>
        /// cOfferGrade属性
        /// <summary>
        public string cOfferGrade { get; set; }

        /// <summary>
        /// iOfferRate属性
        /// <summary>
        public double? iOfferRate { get; set; }

        /// <summary>
        /// pubufts属性
        /// <summary>
        public string pubufts { get; set; }

        /// <summary>
        /// bShop属性
        /// <summary>
        public bool? bShop { get; set; }

        /// <summary>
        /// cDepGUID属性
        /// <summary>
        public Guid? cDepGUID { get; set; }

        /// <summary>
        /// dDepBeginDate属性
        /// <summary>
        public DateTime? dDepBeginDate { get; set; }

        /// <summary>
        /// dDepEndDate属性
        /// <summary>
        public DateTime? dDepEndDate { get; set; }

        /// <summary>
        /// vAuthorizeDoc属性
        /// <summary>
        public string vAuthorizeDoc { get; set; }

        /// <summary>
        /// vAuthorizeUnit属性
        /// <summary>
        public string vAuthorizeUnit { get; set; }

        /// <summary>
        /// cDepFax属性
        /// <summary>
        public string cDepFax { get; set; }

        /// <summary>
        /// cDepPostCode属性
        /// <summary>
        public string cDepPostCode { get; set; }

        /// <summary>
        /// cDepEmail属性
        /// <summary>
        public string cDepEmail { get; set; }

        /// <summary>
        /// cDepType属性
        /// <summary>
        public string cDepType { get; set; }

        /// <summary>
        /// bInheritDutyBasic属性
        /// <summary>
        public int? bInheritDutyBasic { get; set; }

        /// <summary>
        /// bInheritWorkCalendar属性
        /// <summary>
        public int? bInheritWorkCalendar { get; set; }

        /// <summary>
        /// cDutyCode属性
        /// <summary>
        public string cDutyCode { get; set; }

        /// <summary>
        /// cRestCode属性
        /// <summary>
        public string cRestCode { get; set; }

        /// <summary>
        /// bIM属性
        /// <summary>
        public bool? bIM { get; set; }

        /// <summary>
        /// cDepNameEn属性
        /// <summary>
        public string cDepNameEn { get; set; }

        /// <summary>
        /// bRetail属性
        /// <summary>
        public bool? bRetail { get; set; }

        /// <summary>
        /// cDepFullName属性
        /// <summary>
        public string cDepFullName { get; set; }

        /// <summary>
        /// iDepOrder属性
        /// <summary>
        public int? iDepOrder { get; set; }

        /// <summary>
        /// cDepLeader属性
        /// <summary>
        public string cDepLeader { get; set; }

        /// <summary>
        /// dModifyDate属性
        /// <summary>
        public DateTime? dModifyDate { get; set; }


    }
}

