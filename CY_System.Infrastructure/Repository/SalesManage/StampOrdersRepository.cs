using CY_System.DomainStandard;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;

namespace CY_System.Infrastructure.Repository
{
    /// <summary>
    /// StampOrders仓库,该段代码由代码生成器自动生成
    /// 作者: C
    /// 时间: 2018-01-08 16:42:56
    /// </summary>
    public class StampOrdersRepository : BaseRepository<StampOrdersInfo>
    {
        //ToDo:具体的对数据库实现的方法写在这里
        public IEnumerable<StampOrdersInfo> SelectListByCustomer(DateTime fromDate, DateTime toDate, string tName)
        {
            using (var conn = GetConnection())
            {
               return conn.Query<StampOrdersInfo>(@"
                    SELECT  sos.GUID_AutoID,
                      sos.AutoID,
                      sos.Guid_PID,
                      sos.PID,
                      sos.GoodsName,
                      sos.cInvCode,
                      sos.cInvName,
                      sos.StampType,
                      sos.cInvStd,
                      sos.cInvDefine1,
                      sos.cInvDefine2,
                      sos.cInvDefine3,
                      sos.cInvDefine4,
                      sos.cInvDefine5,
                      sos.BorderWidth,
                      sos.StampInk,
                      sos.iQuantity,
                      sos.Discount,
                      sos.iUnitPrice,
                      sos.iCost,
                      sos.StampStyle,
                      sos.StyleRemark,
                      sos.DeliLevel,
                      sos.UrgentPoint,
                      sos.cUrgentCode,
                      sos.IsDeli,
                      sos.DeliDept,
                      sos.DeliAddress,
                      sos.IsChecked,
                      sos.LayoutStatus,
                      sos.Layouter,
                      sos.dLayoutDate,
                      sos.IsScan,
                      sos.BarCode,
                      sos.IsDigital,
                      sos.IsSecurityLine,
                      sos.IsSecurityCode,
                      sos.IsVerify,
                      sos.S_AutoID,
                      sos.ChipID,
                      sos.IsStampTemplate,
                      sos.SCL
           FROM dbo.sa_StampOrders sos LEFT JOIN sa_stamporder so
ON sos.PID = so.ID WHERE so.CreateDate >= @fromDate AND so.CreateDate < @toDate AND so.stampUnit LIKE @stampUnit AND so.status > 20
                    ", new { stampUnit = '%' + tName + '%',
                   fromDate = fromDate.ToString("yyyy-MM-dd"),
                   toDate =toDate.AddDays(1).ToString("yyyy-MM-dd") });
            }
        }
    }
}
