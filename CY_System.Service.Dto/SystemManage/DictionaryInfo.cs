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
    /// 时间：2015-02-03 17:48:50
    /// </summary>
    
    public class DictionaryInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public DictionaryInfo()
        {
            this.ID = 0;
            this.PID = 0;
            this.Name = string.Empty;
            this.IsStop = false;
        }

        #region 受保护的字段
        protected int? m_id;
        protected int? m_pid;
        protected string m_code;
        protected string m_name;
        protected int? m_orders;
        protected bool? m_isstop;
        protected string m_remark;
        #endregion

        #region 共有属性
        /// <summary>
        /// 节点ID
        /// <summary>
        
        public int? ID
        {
            set { m_id = value; }
            get { return m_id; }
        }
        /// <summary>
        /// 父节点ID
        /// <summary>
        
        public int? PID
        {
            set { m_pid = value; }
            get { return m_pid; }
        }
        /// <summary>
        /// 编码
        /// <summary>
        
        public string Code
        {
            set { m_code = value; }
            get { return m_code; }
        }
        /// <summary>
        /// 名称
        /// <summary>
        
        public string Name
        {
            set { m_name = value; }
            get { return m_name; }
        }
        /// <summary>
        /// 排序
        /// <summary>
        
        public int? Orders
        {
            set { m_orders = value; }
            get { return m_orders; }
        }
        /// <summary>
        /// 是否已停用
        /// <summary>
        
        public bool? IsStop
        {
            set { m_isstop = value; }
            get { return m_isstop; }
        }
        /// <summary>
        /// 备注
        /// <summary>
        
        public string Remark
        {
            set { m_remark = value; }
            get { return m_remark; }
        }
        #endregion

    }
}