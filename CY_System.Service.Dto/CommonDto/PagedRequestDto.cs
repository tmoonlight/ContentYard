using System;
using System.Collections.Generic;
using System.Text;

namespace CY_System.Service.Dto
{
    /// <summary>
    /// 分页传输实体(请求)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PagedRequestDto
    {
        /// <summary>
        /// 单页条数
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        public string strSort { get; set; }

        /// <summary>
        /// 正/反排序
        /// </summary>
        public bool bAsc { get; set; }
    }
}
