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
    /// 时间：2015-01-12 17:48:19
    /// </summary>
    
    public class RolesInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public RolesInfo()
        {
            this.ID = 0;
            this.Name = string.Empty;
        }

        #region 受保护的字段
        protected int? m_id;
        protected string m_name;
        protected string m_remark;
        #endregion

        #region 共有属性
        /// <summary>
        /// 角色ID
        /// <summary>
        
        public int? ID
        {
            set { m_id = value; }
            get { return m_id; }
        }
        /// <summary>
        /// 角色名
        /// <summary>
        
        public string Name
        {
            set { m_name = value; }
            get { return m_name; }
        }
        /// <summary>
        /// 描述
        /// <summary>
        
        public string Remark
        {
            set { m_remark = value; }
            get { return m_remark; }
        }
        #endregion

    }
}

