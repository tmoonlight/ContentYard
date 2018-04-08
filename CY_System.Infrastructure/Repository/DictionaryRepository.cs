using CY_System.DomainStandard;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;

namespace CY_System.Infrastructure.Repository
{
    /// <summary>
    /// Dictionary仓库,该段代码由代码生成器自动生成
    /// 作者: C
    /// 时间: 2018-01-17 19:42:37
    /// </summary>
    public class DictionaryRepository : BaseRepository<DictionaryInfo>
    {
        //ToDo:具体的对数据库实现的方法写在这里
        public IEnumerable<DictionaryInfo> SelectListByMultiPid(params int[] pids)
        {
            using (var conn = GetConnection())
            {
                return conn.Query<DictionaryInfo>("SELECT ID, PID, Code, Name, Orders, IsStop, Remark FROM dbo.base_Dictionary WHERE pid IN(" + 
                    string.Join(",", pids) + ")").AsList();
            }
        }

      
    }
}
