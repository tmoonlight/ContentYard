using System;
using System.Collections.Generic;
using System.Text;

namespace CY_System.Service.Dto
{
    /// <summary>
    /// 分页传输实体,如遇分页的情况可使用或扩展此实体
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PagedDto<T> where T : class
    {
        //数据
        public List<T> Data { get; set; }

       
        //总页数
        public int PageCount  { get; set; }
    }
}
