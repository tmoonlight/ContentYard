using CY_System.DomainStandard;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;
using DapperExtensions;

namespace CY_System.Infrastructure.Repository
{
    /// <summary>
    /// StampQuoteItem仓库,该段代码由代码生成器自动生成
    /// 作者: C
    /// 时间: 2018-03-12 14:06:02
    /// </summary>
    public class StampQuoteItemRepository : BaseRepository<StampQuoteItemInfo>
    {
        //ToDo:具体的对数据库实现的方法写在这里
        /// <summary>
        /// 根据quoteid删除报价单明细
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteWithQuoteID(int id)
        {
            using (var conn = GetConnection())
            {
                conn.Execute("delete from sa_StampQuoteItem where StampQuoteID = @quoteId", new { quoteId = id });
                return true;
            }
        }
    }
}
