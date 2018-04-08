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
    /// 时间：2016/1/27 9:38:50
    /// </summary>
    
    public class SignInDetailInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public SignInDetailInfo()
        {
            this.SD_ID = 0;
            this.CurState = TState.None;
        }

        /// <summary>
        /// 
        /// <summary>
        
        public int? SD_ID { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public DateTime? SD_Date { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public DateTime? SD_Up { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public DateTime? SD_Down { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cUser_Id { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string Team_cCode { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cMemo { get; set; }

        /// <summary>
        /// 数据行状态
        /// <summary>
        
        public TState CurState { get; set; }


    }
}

