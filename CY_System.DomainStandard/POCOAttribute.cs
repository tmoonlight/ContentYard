using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CY_System.DomainStandard
{
    /// <summary>
    /// 实体到表字段的映射信息
    /// </summary>
    [AttributeUsage(AttributeTargets.Class , AllowMultiple = false)]
    public class POCOAttribute : Attribute
    {
        /// <summary>
        /// 原始表名
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// 数据库名
        /// </summary>
        //public string DbName { get; set; }

        /// <summary>
        /// 数据库连接名
        /// </summary>
        public string DbConnName { get; set; }
    }


    [AttributeUsage(AttributeTargets.Property)]
    public class FieldAttribute : Attribute
    {
       ///// <summary>
       // /// 标识为主键
       // /// </summary>
       // public bool IsKey { get; set; }
        /// <summary>
        /// 列名称
        /// </summary>
        public string Column { get; set; }
        /// <summary>
        /// 大小|长度
        /// </summary>
        public int Size { get; set; }
        /// <summary>
        /// 数据类型
        /// </summary>
        public SqlDbType DBType { get; set; }
        /// <summary>
        /// 标识不是映射字段
        /// </summary>
        public bool NotMapping { get; set; }
    }

    /// <summary>
    /// 标识列字段
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class IdentityAttribute : Attribute
    {

    }
}
