using CY_System.DomainStandard;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;

namespace CY_System.Infrastructure.Repository
{
    /// <summary>
    /// StampQuote仓库,该段代码由代码生成器自动生成
    /// 作者: C
    /// 时间: 2018-03-12 14:06:02
    /// </summary>
    public class StampQuoteRepository : BaseRepository<StampQuoteInfo>
    {
        //ToDo:具体的对数据库实现的方法写在这里
        public bool ConfirmStampQuote(int qId, bool isPass, bool signed = false)
        {
            string nextStatus = "35";//审核通过,签章中
            if (!isPass)
            {
                //打回
                nextStatus = "10";
            }
            if (signed)
            {
                nextStatus = "40";//已审核
            }


            using (var conn = GetConnection())
            {
                return conn.Execute("update sa_stampquote set status = @status where ID = @quoteId",
                     new
                     {
                         status = nextStatus,
                         quoteId = qId
                     }
                     ) > 0;
            }

        }

        public bool Rollback_ConfirmStampQuote(int qId)
        {
            string nextStatus = "20";//待审核

            using (var conn = GetConnection())
            {
                return conn.Execute("update sa_stampquote set status = @status where ID = @quoteId",
                     new
                     {
                         status = nextStatus,
                         quoteId = qId
                     }
                     ) > 0;
            }

        }

        /// <summary>
        /// 取消报价单
        /// </summary>
        /// <param name="qId"></param>
        /// <returns></returns>
        public bool AbandonQuote(int qId)
        {
           using (var conn = GetConnection())
            {
                return conn.Execute("update sa_stampquote set IsAbandon = 'Y' where ID = @quoteId",
                     new
                     {
                         quoteId = qId
                     }
                     ) > 0;
            }
        }
    }
}
