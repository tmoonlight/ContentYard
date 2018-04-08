using CY_System.DomainStandard;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;
using DapperExtensions;
using Dapper;

namespace CY_System.Infrastructure.Repository
{
    /// <summary>
    /// StampProperties仓库,该段代码由代码生成器自动生成
    /// 作者: C
    /// 时间: 2018-01-17 15:11:50
    /// </summary>
    public class StampPropertiesRepository : BaseRepository<StampPropertiesInfo>
    {
        //ToDo:具体的对数据库实现的方法写在这里
        /// <summary>
        /// 增加历史记录
        /// </summary>
        /// <param name="subspis"></param>
        /// <param name="strStampStyle"></param>
        /// <param name="oldTime"></param>
        /// <returns></returns>
        public int AddHistory(List<StampPropertiesInfo> subspis, string strStampStyle, DateTime oldTime)
        {
            using (var conn = GetConnection())
            {

                //strStampStyle参数存在一个较小的注入隐患,可先不处理
                return conn.Execute(@"INSERT INTO sa_StampPropertiesHistory(PID,
RowNo,StampContent,FontStyle,CreateDate,StampStyle,Remark)
                                        VALUES ( @PID,@RowNo,@StampContent,@FontStyle,GETDATE()," + strStampStyle + ",@Remark );", subspis);
                            
            }

        }
    }
}
