using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace CY_System.Service.Dto
{
    /// <summary>
    /// 客户相关信息：客户分类、客户信息、联系人信息
    /// 客户分类
    /// 作者：田大伟
    /// 时间：2015-03-03 9:50:10
    /// </summary>
    
    public class CustomerAll_Class
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public CustomerAll_Class() { }

        /// <summary>
        /// 分类编号
        /// <summary>
        
        public string cCCCode { get; set; }

        /// <summary>
        /// 分类名称
        /// <summary>
        
        public string cCCName { get; set; }
    }

    /// <summary>
    /// 客户相关信息：客户分类、客户信息、联系人信息
    /// 客户信息
    /// </summary>
    
    public class CustomerAll_Customer
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public CustomerAll_Customer()
        {
            this.CurState = TState.None;
        }
        
        /// <summary>
        /// 客户编号
        /// </summary>
        
        public string cCusCode { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        
        public string cCusName { get; set; }

        /// <summary>
        /// 客户简称
        /// </summary>
        
        public string cCusAbbName { get; set; }

        /// <summary>
        /// 分类编号
        /// </summary>
        
        public string cCCCode { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        
        public string cCusCName { get; set; }

        /// <summary>
        /// 客户手机标识号
        /// </summary>
        
        public string cCusDefine1 { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        
        public string Operator { get; set; }

        /// <summary>
        /// 记录状态
        /// </summary>
        
        public TState CurState { get; set; }
    }

    /// <summary>
    /// 客户相关信息：客户分类、客户信息、联系人信息
    /// 联系人信息
    /// </summary>
    
    public class CustomerAll_Linkman
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public CustomerAll_Linkman()
        {
            this.CurState = TState.None;
        }

        /// <summary>
        /// Guid 编号
        /// <summary>
        
        public string OID { get; set; }

        /// <summary>
        /// 联系人编号
        /// <summary>
        
        public string cContactCode { get; set; }

        /// <summary>
        /// 联系人名称
        /// <summary>
        
        public string cContactName { get; set; }

        /// <summary>
        /// 所属客户
        /// <summary>
        
        public string cCusCode { get; set; }

        /// <summary>
        /// 性别
        /// <summary>
        
        public string bcSexID { get; set; }

        /// <summary>
        /// 生日
        /// <summary>
        
        public DateTime? dBirthday { get; set; }

        /// <summary>
        /// 移动电话
        /// <summary>
        
        public string cMobilePhone { get; set; }

        /// <summary>
        /// 固定电话
        /// <summary>
        
        public string cOfficePhone { get; set; }

        /// <summary>
        /// 兴趣爱好
        /// <summary>
        
        public string cMemo { get; set; }

        /// <summary>
        /// 操作人
        /// <summary>
        
        public string Operator { get; set; }

        /// <summary>
        /// 记录状态
        /// </summary>
        
        public TState CurState { get; set; }
    }
}
