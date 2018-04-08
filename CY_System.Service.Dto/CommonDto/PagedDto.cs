using System;
using System.Collections.Generic;
using System.Text;

namespace CY_System.Service.Dto
{
    /// <summary>
    /// 错误实体,当出现500等http错误时将此类型数据包一并返回
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ErrorDto
    {
        /// <summary>
        /// 错误内容
        /// </summary>
        public string Msg { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// 跟踪信息(Debug时返回)
        /// </summary>
        public int Trace  { get; set; }
    }
}
