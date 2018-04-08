using CY_System.DomainStandard;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;

namespace CY_System.Infrastructure.Repository
{
    /// <summary>
    /// PayRecords仓库,该段代码由代码生成器自动生成
    /// 作者: C
    /// 时间: 2018-01-22 15:49:01
    /// </summary>
    public class PayRecordsRepository : BaseRepository<PayRecordsInfo>
    {
        //ToDo:具体的对数据库实现的方法写在这里
        public void UpdatePrePay(StampOrderInfo soi, SealCertificateContentInfo model, string pzcode)
        {
            PayRecordsInfo pri = new PayRecordsInfo();
            PayRecordsRepository prRepo = new PayRecordsRepository();
            pri.BName = "承接业务";
            //pri.BID = iId;
            pri.iRowNo = 1;
            pri.iPayCost = model.CurPay == null ? 0 : double.Parse(model.CurPay);
            pri.PayType = model.PayType;
            pri.Handler = model.Handle;
            pri.cDepCode = model.cDepCode;
            pri.cTeamCode = model.cTeamCode;
            pri.dPayDate = BaseClass.GetSystemDate();
            pri.Remark = "凭证预付款";
            prRepo.Add(pri);
            using (var conn = GetConnection())
            {
                dynamic payObj = conn.QueryFirst(@"select isnull(SUM(a.iPayCost),0) paycost 
 FROM [UFDATA_006_2015].[dbo].[sa_PayRecords] a left join [UFDATA_006_2015].[dbo].[sa_StampOrderNew] b on a.BID=b.ID 
 where b.CertificateCode=@p0 and b.Status<>119 and a.Remark='凭证预付款'", new { p0 = pzcode });
                dynamic payCA = conn.QueryFirst(@"select isnull(SUM(a.iPayCost),0) paycost 
FROM [CA].[dbo].[ca_CAPayRecords] a left join [CA].[dbo].[ca_Order] b on a.BID=b.ID 
where b.CertificateCode=@p0 and b.Status<>119 and a.Remark='凭证预付款'", new { p0 = pzcode });
                double paytol = 0;
                if (payObj != null)
                {
                    //PayRecordsInfo priex = PayRecordsBLL.GetInstance().SelectModelByCode(dtpay.Rows[0]["paycost"].ToString());
                    paytol = payObj.paycost;
                }
                if (payCA != null)
                {
                    //CAPayRecordsInfo priex1 = CAPayRecordsBLL.GetInstance().SelectModelByCode(dtpayCA.Rows[0]["paycost"].ToString());
                    paytol += payCA.paycost;
                }
                if (model.TolPay == null)
                {
                    model.TolPay = "0";
                }
                if (paytol == double.Parse(model.TolPay))
                {
                    conn.Execute(@"update [UFDATA_006_2015].[dbo].[SealCertificateContent] 
set Status='20' where CertificateCode=@p0",new { p0 = pzcode });
                }
            }
        }
    }
}
