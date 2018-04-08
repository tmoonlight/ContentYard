using CY_System.DomainStandard;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;

namespace CY_System.Infrastructure.Repository
{
    /// <summary>
    /// AllTaxInfo仓库,该段代码由代码生成器自动生成
    /// 作者: Anton-PC
    /// 时间: 2018-02-26 15:47:35
    /// </summary>
    public class AllTaxInfoRepository : BaseRepository<AllTaxInfoInfo>
    {
        //ToDo:具体的对数据库实现的方法写在这里

        public IEnumerable<AllTaxInfoInfo> SelectWherelist()
        {
            using (var conn = GetConnection())
            {
                var result = conn.Query<AllTaxInfoInfo>(@"select * from dbo.cy_AllTaxInfo");
                return result;
            }
        }

        public AllTaxInfoInfo SelectModel(string IdentityNum)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    var result = conn.Query<AllTaxInfoInfo>(@"select * from dbo.cy_AllTaxInfo where IdentityNum=@IdentityNum",new { IdentityNum  = IdentityNum });
                    List<AllTaxInfoInfo> lst = result.AsList<AllTaxInfoInfo>();
                    if (lst.Count > 0)
                    {
                        return lst[0];
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch { return null; }
        }
    }
}
