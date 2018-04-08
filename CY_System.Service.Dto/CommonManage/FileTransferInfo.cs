using System;
using System.IO;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace CY_System.Service.Dto
{
    /// <summary>
    /// 该段代码由代码生成器自动生成
    /// 作者：田大伟
    /// 时间：2015-03-19 9:52:08
    /// </summary>
    
    public class FileTransferInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public FileTransferInfo()
        {
            this.ID = 0;
            this.GuidID = string.Empty;
            this.BID = 0;
            this.GuidBID = string.Empty;
            this.Orders = 1;
            this.BName = string.Empty;
            this.OrgName = string.Empty;
            this.SaveName = string.Empty;
            this.Operator = string.Empty;
            this.dDate = DateTime.Now;
            this.FileData = new byte[0];
        }

        /// <summary>
        /// 主键id
        /// <summary>
        
        public int? ID { get; set; }

        /// <summary>
        /// 主键guidid
        /// <summary>
        
        public string GuidID { get; set; }

        /// <summary>
        /// 序号
        /// <summary>
        
        public int Orders { get; set; }

        /// <summary>
        /// 使用附件模块
        /// <summary>
        
        public string BName { get; set; }

        /// <summary>
        /// 附件关联外键id
        /// <summary>
        
        public int? BID { get; set; }

        /// <summary>
        /// 附件关联外键guidid
        /// <summary>
        
        public string GuidBID { get; set; }

        /// <summary>
        /// 原文件名称
        /// <summary>
        
        public string OrgName { get; set; }

        /// <summary>
        /// 保存文件名称
        /// <summary>
        
        public string SaveName { get; set; }

        /// <summary>
        /// 操作人
        /// <summary>
        
        public string Operator { get; set; }

        /// <summary>
        /// 操作日期
        /// <summary>
        
        public DateTime? dDate { get; set; }

        /// <summary>
        /// 操作日期
        /// <summary>
        
        public string cCode { get; set; }

        /// <summary>
        /// 附件内容
        /// </summary>
        
        public byte[] FileData { get; set; }

        /// <summary>
        /// 实体状态
        /// </summary>
        
        public TState CurState { get; set; }
    }
}

