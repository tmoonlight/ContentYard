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
    /// 时间：2015-01-12 17:48:18
    /// </summary>
    
    public class RoleFunctionsInfo
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public RoleFunctionsInfo()
        {
            this.Role_ID = 0;
            this.Function_ID = 0;
        }

        #region 受保护的字段
        protected int? m_role_id;
        protected int? m_function_id;
        #endregion

        #region 共有属性
        /// <summary>
        /// 角色ID
        /// <summary>
        
        public int? Role_ID
        {
            set { m_role_id = value; }
            get { return m_role_id; }
        }
        /// <summary>
        /// 功能ID
        /// <summary>
        
        public int? Function_ID
        {
            set { m_function_id = value; }
            get { return m_function_id; }
        }
        #endregion

    }
}

