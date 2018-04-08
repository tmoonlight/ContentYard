using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.Service.Dto
{
    /// <summary>
    /// 该段代码由代码生成器自动生成
    /// 作者：田大伟
    /// 时间：2015-04-18 18:09:31
    /// </summary>
    
    public class TeamInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public TeamInfo()
        {
            this.cCode = string.Empty;
            this.CurState = TState.None;
            this.cTeamDefine15 = Convert.ToDateTime("2016-01-01 09:00:00.000");
            this.cTeamDefine16 = Convert.ToDateTime("2016-01-01 18:00:00.000");
        }

        /// <summary>
        /// 
        /// <summary>
        
        public string cCode { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string vName { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cDepCode { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string dEstablisheDate { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string dWithdrawalDate { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cLeader { get; set; }

        /// <summary>
        /// 负责人
        /// <summary>
        
        public string LeaderName { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public bool? bMOTeam { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public bool? bSaleTeam { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public bool? bServiceTeam { get; set; }

        /// <summary>
        /// 设置
        /// <summary>
        
        public string cTeamDefine5 { get; set; }
        
        /// <summary>
        /// 业务组简称
        /// <summary>
        
        public string cTeamDefine4 { get; set; }

        /// <summary>
        /// 业务组电话
        /// <summary>
        
        public string cTeamDefine6 { get; set; }

        /// <summary>
        /// 业务组地址
        /// <summary>
        
        public string cTeamDefine7 { get; set; }

        /// <summary>
        /// 治安系统部门ID
        /// <summary>
        
        public string cTeamDefine9 { get; set; }

        /// <summary>
        /// 数据行状态
        /// <summary>
        
        public TState CurState { get; set; }

        /// <summary>
        /// 上班打卡时间
        /// <summary>
        
        public DateTime cTeamDefine15 { get; set; }

        /// <summary>
        /// 下班打卡时间
        /// <summary>
        
        public DateTime cTeamDefine16 { get; set; }


    }
}

