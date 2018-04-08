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
    /// 时间：2015-04-17 12:02:32
    /// </summary>
    
    public class DepartmentInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public DepartmentInfo()
        {
            this.cDepCode = string.Empty;
            this.cDepName = string.Empty;
            this.bDepEnd = false;
            this.iDepGrade = 1;
        }

        /// <summary>
        /// 
        /// <summary>
        
        public string cDepCode { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cDepName { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cDepNameEn { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cDepPerson { get; set; }
        /// <summary>
        /// 负责人名称
        /// <summary>
        
        public string PersonName { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cDepLeader { get; set; }
        /// <summary>
        /// 分管领导名称
        /// <summary>
        
        public string LeaderName { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public DateTime? dDepBeginDate { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public DateTime? dDepEndDate { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cDepAddress { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public bool? bDepEnd { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public byte? iDepGrade { get; set; }

        /// <summary>
        /// 
        /// <summary>
        
        public string cDepFullName { get; set; }

    }
}

