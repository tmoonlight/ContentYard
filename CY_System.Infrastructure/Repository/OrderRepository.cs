using CY_System.DomainStandard;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;

namespace CY_System.Infrastructure.Repository
{
    /// <summary>
    /// (示例)订单仓库
    /// </summary>
    public class OrderRepository : BaseRepository_CA<OrderInfo>
    {

        public BaseRepository_CA<OrderInfo> repo = new BaseRepository_CA<OrderInfo>();
        public IEnumerable<T> TQuery<T>(IDbConnection connection, Func<T> typeBuilder, string sql)
        {
            return connection.Query<T>(sql);
        }
        //ToDo:具体的对数据库实现的方法写在这里
        public IEnumerable<dynamic> SelectOrderDetail()
        {

            IEnumerable<OrderInfoWithOrderCount> returnvalue = null;
            try
            {
                using (var conn = GetConnection())
                {
                    returnvalue = conn.Query<OrderInfo, OrderInfoWithOrderCount, OrderInfoWithOrderCount>(@"SELECT   ca_Order.ID 
                                        COUNT(*) ItemCount
                               FROM     ca_Order,
                                        ca_OrderMatters
                               WHERE    ca_Order.ID = ca_OrderMatters.PID
                               GROUP BY dbo.ca_Order.ID", (order1, order2) => { order2.Orderinfo = order1; return order2; });


                    var returnvalue2 = TQuery(conn, () => new
                    {
                        ContactId = default(int),
                        Name = default(string),
                    }, @"SELECT   ca_Order.ID 
                                        COUNT(*) ItemCount
                               FROM     ca_Order,
                                        ca_OrderMatters
                               WHERE    ca_Order.ID = ca_OrderMatters.PID
                               GROUP BY dbo.ca_Order.ID");

                    return returnvalue;
                }
            }
            catch (Exception ex)
            {

            }
            return returnvalue;
        }

        //ToDo:具体的对数据库实现的方法写在这里
        public dynamic SelectOrderDetail2()
        {
            using (var conn = GetConnection())
            {

                var returnvalue = conn.Query(@"SELECT   ca_Order.ID ,
                                        COUNT(*) ItemCount
                               FROM     ca_Order,
                                        ca_OrderMatters
                               WHERE    ca_Order.ID = ca_OrderMatters.PID
                               GROUP BY dbo.ca_Order.ID");


                return returnvalue;
            }

            return new { x = 1, y = 2 };
        }


        public string TestDapperTVP()
        {
            List<OrderInfo> olist = new List<OrderInfo>() {

                new OrderInfo{ CACode = "TEST11" },
                new OrderInfo{ CACode = "TEST22" },
                new OrderInfo{ CACode = "TEST55" },
                new OrderInfo{ CACode = "TEST33" },
                new OrderInfo{ CACode = "TEST44" }
            };
            OrderInfo oi = new OrderInfo();
            oi.CACode = "";
            oi.cContactCode = "";
            oi.cDepCode = "";
            var dt = new DataTable();
            dt.Columns.Add("CACode", typeof(long));
            dt.Columns.Add("cContactCode", typeof(string));
            dt.Columns.Add("cDepCode", typeof(bool));
            dt.Rows.Add("", "EHLO", null);
            dt.Rows.Add("", "EHLO", null);
            using (var conn = GetConnection())
            {

                conn.Execute("ins");
            }
            return "";
        }

        #region 

        /// <summary>
        /// 承接缴款验证(各业务缴款判断当天营业额是否等于缴款额)
        /// </summary>
        /// <param name="funModule">业务类型（承接业务,代办业务,数字证书）</param>
        /// <param name="cTeamCode">地区\门店编号</param>
        /// <param name="datePay">缴款时间</param>
        /// <returns></returns>
        public bool teamPaymentValueChecked(string funModule, string cTeamCode, DateTime datePay)
        {
            try
            {
                string sqlPay = string.Empty;
                string connectionString = string.Empty;
                if (funModule == "承接业务")
                {
                    sqlPay = string.Format(@"SELECT Code
FROM   dbo.sa_StampOrder
WHERE  Status <> 119 and Status >=20
       AND DATEDIFF(d, CreateDate, '{1}')=0
       AND DATEDIFF(s, CreateDate,'{1}')<0
       AND (cTeamCode = '{0}' OR cDepCode='{0}')", cTeamCode, datePay);
                    connectionString = CY_SystemConsts.ConnectionString_conn;
                }
                else if (funModule == "数字证书")
                {
                    sqlPay = string.Format(@"SELECT CACode
FROM   dbo.ca_Order
WHERE  Status <> 119
       AND DATEDIFF(d, CreateDate, '{1}')=0
       AND DATEDIFF(s, CreateDate,'{1}')<0
       AND (cTeamCode = '{0}' OR cDepCode='{0}')", cTeamCode, datePay);
                    connectionString = CY_SystemConsts.ConnectionString_conn_ca;
                }
                else if (funModule == "代办业务")
                {
                    sqlPay = string.Format(@"SELECT IHCode
FROM   dbo.ih_InsteadHandleOrder
WHERE  Status <> 119
       AND DATEDIFF(d, CreateDate, '{1}')=0
       AND DATEDIFF(s, CreateDate,'{1}')<0
       AND (cTeamCode = '{0}' OR cDepCode='{0}')", cTeamCode, datePay);
                    connectionString = CY_SystemConsts.ConnectionString_conn_ih;
                }
                using (var conn = ConnectionFactory.CreateConnection(connectionString))
                {
                    List<dynamic> result = conn.Query(sqlPay).AsList<dynamic>();
                    if (result.Count > 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            catch { return false; }
        }


        #endregion
    }
}
