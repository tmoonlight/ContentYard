using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CY_System.Service.Dto
{
    /// <summary>
    /// 实体到表字段的映射信息
    /// </summary>
    
    public class EntityFieldAttribute : Attribute
    {
        /// <summary>
        /// 标识为主键
        /// 
        /// </summary>
        public bool IsKey { get; set; }
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
}
