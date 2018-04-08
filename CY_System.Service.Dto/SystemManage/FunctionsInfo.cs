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
    /// 时间：2015-02-04 12:41:54
    /// </summary>
    
    public class FunctionsInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public FunctionsInfo()
        {
            this.ID = 0;
            this.PID = 0;
            this.Name = string.Empty;
            this.Orders = 0;
            this.IsVisible = false;
        }

        #region 受保护的字段
        protected int? m_id;
        protected int? m_pid;
        protected string m_name;
        protected string m_ctype;
        protected string m_imageurl;
        protected int? m_orders;
        protected string m_ctrl_id;
        protected bool? m_isvisible;
        protected string m_remark;
        #endregion

        #region 共有属性
        /// <summary>
        /// 功能ID
        /// <summary>
        
        public int? ID
        {
            set { m_id = value; }
            get { return m_id; }
        }
        /// <summary>
        /// 上级功能ID
        /// <summary>
        
        public int? PID
        {
            set { m_pid = value; }
            get { return m_pid; }
        }
        /// <summary>
        /// 功能名称
        /// <summary>
        
        public string Name
        {
            set { m_name = value; }
            get { return m_name; }
        }
        /// <summary>
        /// 功能类型
        /// <summary>
        
        public string cType
        {
            set { m_ctype = value; }
            get { return m_ctype; }
        }
        /// <summary>
        /// 图片链接
        /// <summary>
        
        public string ImageUrl
        {
            set { m_imageurl = value; }
            get { return m_imageurl; }
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
        /// 界面控件ID
        /// <summary>
        
        public string Ctrl_ID
        {
            set { m_ctrl_id = value; }
            get { return m_ctrl_id; }
        }
        /// <summary>
        /// 功能是否可见
        /// <summary>
        
        public bool? IsVisible
        {
            set { m_isvisible = value; }
            get { return m_isvisible; }
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