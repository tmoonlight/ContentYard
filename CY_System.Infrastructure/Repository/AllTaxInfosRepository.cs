using CY_System.DomainStandard;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;

namespace CY_System.Infrastructure.Repository
{
    /// <summary>
    /// AllTaxInfos仓库,该段代码由代码生成器自动生成
    /// 作者: Anton-PC
    /// 时间: 2018-02-26 15:47:35
    /// </summary>
    public class AllTaxInfosRepository : BaseRepository<AllTaxInfosInfo>
    {
        //ToDo:具体的对数据库实现的方法写在这里

        /// <summary>
        /// 绑定菜单树
        /// </summary>
        /// <returns></returns>
        public IEnumerable<dynamic> SelectDataTable()
        {
            try
            {
                using (var conn = GetConnection())
                {
                    //strStampStyle参数存在一个较小的注入隐患,可先不处理
                    string sql = @"select dep.cDepCode 
      ,dep.cDepName
      ,team.cCode
      ,team.vName
      ,at.*
from dbo.Team team 
left join dbo.Department dep on team.cDepCode=dep.cDepCode
left join dbo.cy_AllTaxInfos ats on ats.cTeamCode=team.cCode
left join dbo.cy_AllTaxInfo at on ats.IdentityNum=at.IdentityNum";
                    return conn.Query(sql);
                }
            }
            catch { return null; }
        }

        public AllTaxInfosInfo SelectModel(string cTeamCode)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    var result = conn.Query<AllTaxInfosInfo>(@"select * from cy_AllTaxInfos where cTeamCode=@Code", new { Code = cTeamCode });
                    if (result != null && result.AsList().Count > 0) { return result.AsList()[0]; }
                    else { return null; }
                }
            }
            catch { return null; }
        }

        public int Updates(AllTaxInfosInfo model)
        {
            try
            {
                using (var conn = GetConnection())
                {
                    return conn.Execute(@"Update cy_AllTaxInfos set IdentityNum=@IdentityNum where cTeamCode=@cTeamCode", new { cTeamCode = model.cTeamCode, IdentityNum = model.IdentityNum });
                }
            }
            catch { return 0; }
        }
    }
}
