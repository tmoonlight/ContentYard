using CY_System.DomainStandard;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;

namespace CY_System.Infrastructure.Repository
{
    /// <summary>
    /// StampStorePayment仓库,该段代码由代码生成器自动生成
    /// 作者: C
    /// 时间: 2018-01-12 11:55:24
    /// </summary>
    public class StampStorePaymentRepository : BaseRepository<StampStorePaymentInfo>
    {
        //ToDo:具体的对数据库实现的方法写在这里
        public IEnumerable<StampStorePaymentInfo> SelectListBycDepCodeAndcTeamCode(string cDept_num, string cDutyclass)
        {
            using (var conn = GetConnection())
            {
                return conn.Query<StampStorePaymentInfo>(@"SELECT * FROM sa_StampStorePayment
 WHERE cDepCode = @p0 and cTeamCode = @p1
 AND CreateDate >= @p2
 AND CreateDate < @p3 ", new
                {
                    p0 = cDept_num,
                    p1 = cDutyclass,
                    p2 = DateTime.Now.Date,
                    p3 = DateTime.Now.Date.AddDays(1),
                });
            }
        }
    }
}
