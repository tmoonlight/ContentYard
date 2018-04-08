using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.DomainStandard
{
    /// <summary>
	/// Team实体类
    /// 作者: C
    /// 时间: 2018-01-26 11:51:12
    /// </summary>
    [POCO(DbConnName = CY_SystemConsts.ConnectionString_conn, TableName = "Team")]
    public class TeamInfo
    {
        /// <summary>
        /// PK_Team属性
        /// <summary>
        public Guid? PK_Team { get; set; }

        /// <summary>
        /// cCode属性
        /// <summary>
        public string cCode { get; set; }

        /// <summary>
        /// vName属性
        /// <summary>
        public string vName { get; set; }

        /// <summary>
        /// cDepCode属性
        /// <summary>
        public string cDepCode { get; set; }

        /// <summary>
        /// dEstablisheDate属性
        /// <summary>
        public string dEstablisheDate { get; set; }

        /// <summary>
        /// dWithdrawalDate属性
        /// <summary>
        public string dWithdrawalDate { get; set; }

        /// <summary>
        /// cLeader属性
        /// <summary>
        public string cLeader { get; set; }

        /// <summary>
        /// bMOTeam属性
        /// <summary>
        public bool? bMOTeam { get; set; }

        /// <summary>
        /// wccode属性
        /// <summary>
        public string wccode { get; set; }

        /// <summary>
        /// bPRTeam属性
        /// <summary>
        public bool? bPRTeam { get; set; }

        /// <summary>
        /// PreSubID属性
        /// <summary>
        public string PreSubID { get; set; }

        /// <summary>
        /// PreCode属性
        /// <summary>
        public string PreCode { get; set; }

        /// <summary>
        /// cTeamDefine1属性
        /// <summary>
        public string cTeamDefine1 { get; set; }

        /// <summary>
        /// cTeamDefine2属性
        /// <summary>
        public string cTeamDefine2 { get; set; }

        /// <summary>
        /// cTeamDefine3属性
        /// <summary>
        public string cTeamDefine3 { get; set; }

        /// <summary>
        /// cTeamDefine4属性
        /// <summary>
        public string cTeamDefine4 { get; set; }

        /// <summary>
        /// cTeamDefine5属性
        /// <summary>
        public string cTeamDefine5 { get; set; }

        /// <summary>
        /// cTeamDefine6属性
        /// <summary>
        public string cTeamDefine6 { get; set; }

        /// <summary>
        /// cTeamDefine7属性
        /// <summary>
        public string cTeamDefine7 { get; set; }

        /// <summary>
        /// cTeamDefine8属性
        /// <summary>
        public string cTeamDefine8 { get; set; }

        /// <summary>
        /// cTeamDefine9属性
        /// <summary>
        public string cTeamDefine9 { get; set; }

        /// <summary>
        /// cTeamDefine10属性
        /// <summary>
        public string cTeamDefine10 { get; set; }

        /// <summary>
        /// cTeamDefine11属性
        /// <summary>
        public int? cTeamDefine11 { get; set; }

        /// <summary>
        /// cTeamDefine12属性
        /// <summary>
        public int? cTeamDefine12 { get; set; }

        /// <summary>
        /// cTeamDefine13属性
        /// <summary>
        public double? cTeamDefine13 { get; set; }

        /// <summary>
        /// cTeamDefine14属性
        /// <summary>
        public double? cTeamDefine14 { get; set; }

        /// <summary>
        /// cTeamDefine15属性
        /// <summary>
        public DateTime? cTeamDefine15 { get; set; }

        /// <summary>
        /// cTeamDefine16属性
        /// <summary>
        public DateTime? cTeamDefine16 { get; set; }

        /// <summary>
        /// pubufts属性
        /// <summary>
        public string pubufts { get; set; }

        /// <summary>
        /// bBusTeam属性
        /// <summary>
        public bool? bBusTeam { get; set; }

        /// <summary>
        /// bSaleTeam属性
        /// <summary>
        public bool? bSaleTeam { get; set; }

        /// <summary>
        /// bServiceTeam属性
        /// <summary>
        public bool? bServiceTeam { get; set; }


    }
}

