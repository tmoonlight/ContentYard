using System;
using System.Collections.Generic;
using System.Text;

namespace CY_System.Infrastructure
{
    public class SqlStringHelper
    {
        /// <summary>
        /// 将一个全查询SQL转换为分页SQL,该SQL必须以select XXX开头,其中strSort可被注入,切勿从用户端传入。
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="pageSize"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageCount"></param>
        /// <param name="strSort">必须指定</param>
        /// <param name="bAsc"></param>
        /// <returns></returns>
        public static string ConvertToPagedSQL(string sql, int pageSize, int pageIndex, string strSort, bool bAsc)
        {
            if (string.IsNullOrEmpty(strSort)) throw new Exception("必须传入sql语句");
            if (string.IsNullOrEmpty(strSort)) throw new Exception("分页语句必须指定排序字段");
            string countSql = string.Format("SELECT count(*) FROM ({0}) AS Temp_TB2", sql);
            string sql_sort = string.Format("{0} {1}", string.IsNullOrEmpty(strSort) ? "id" : strSort, bAsc ? "asc" : "desc");
            string sql_select = string.Format(@"select * from 
	                                (select ROW_NUMBER() over (order by {2}) 'RowIndex'," + sql.Replace("\r", " ").Replace("\n", " ").Trim().Substring(7) + @") as Temp
	                                where RowIndex>{0} and RowIndex <={1}",
                                                                          Convert.ToString(pageSize * pageIndex),
                                                                          Convert.ToString(pageSize * (pageIndex + 1)),
                                                                          sql_sort);
            return countSql+";"+ sql_select ;
        }
    }
}
