using CY_System.DomainStandard;
using System;
using System.Collections.Generic;
using System.Text;
using Dapper;
using System.Data;
using SealWebService;
using System.Threading.Tasks;
using System.Linq;

namespace CY_System.Infrastructure.Repository
{
    /// <summary>
    /// StampOrder仓库,该段代码由代码生成器自动生成
    /// 作者: C
    /// 时间: 2018-01-03 16:34:20
    /// </summary>
    public class StampOrderRepository : BaseRepository<StampOrderInfo>
    {
        //ToDo:具体的对数据库实现的方法写在这里
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cDept_num"></param>
        /// <param name="cDutyclass"></param>
        /// <param name="sysDateTime"></param>
        /// <returns></returns>
        public StampOrderInfo GetLastOrder(string cDept_num, string cDutyclass, string sysDateTime)
        {
            StampOrderInfo stampOrderInfo = null;
            using (var conn = GetConnection())
            {
                stampOrderInfo = conn.QueryFirst<StampOrderInfo>(@"select * from 
 UFDATA_006_2015.dbo.sa_StampOrder where cDepCode=@p_cDept_num
 and cTeamCode=@p_cDutyclass and CreateDate<@p_sysDateTime
 and CreateDate >'2017-05-10' order by CreateDate desc",
                 new
                 {
                     p_cDept_num = cDept_num,
                     p_cDutyclass = cDutyclass,
                     p_sysDateTime = sysDateTime
                 });
            }
            return stampOrderInfo;
        }

        /// <summary>
        /// 计算单据未转交数超过上限的条数
        /// </summary>
        /// <param name="teamcode"></param>
        /// <param name="strTime"></param>
        /// <returns></returns>
        public List<dynamic> GetWarningCount(string teamcode, string strTime)
        {
            using (var conn = GetConnection())
            {
                return conn.Query<dynamic>(@"SELECT so.cTeamCode,so.OrderCount,ISNULL(sw.CZJ,0) WarningCount
                     FROM (SELECT cTeamCode,COUNT(*) OrderCount
                             FROM dbo.sa_StampOrder
                            WHERE cTeamCode='@p0' AND CreateDate>'@p1' AND Status='10'
                            GROUP BY cTeamCode) so
                     LEFT JOIN (select * from dbo.Sa_StampCreateNewControl k where k.ISActive='true' and CKZJ='true') sw ON sw.cTeamCode=so.cTeamCode
                   ",
                 new
                 {
                     p0 = teamcode,
                     p1 = strTime
                 }).AsList();
            }
            //原sql
            //string strSql = string.Format(@"
            //       SELECT so.cTeamCode,so.OrderCount,ISNULL(sw.CZJ,0) WarningCount
            //         FROM (SELECT cTeamCode,COUNT(*) OrderCount
            //                 FROM dbo.sa_StampOrder
            //                WHERE cTeamCode='{0}' AND CreateDate>'{1}' AND Status='10'
            //                GROUP BY cTeamCode) so
            //         LEFT JOIN (select * from dbo.Sa_StampCreateNewControl k where k.ISActive='true' and CKZJ='true') sw ON sw.cTeamCode=so.cTeamCode
            //       ",
            //    teamcode, strTime);
            //dynamic d = bcbll.GetDataTableBySql(strSql);
        }

        public int AddStampOrder(StampOrderInfo dInfo)
        {
            using (var conn = GetConnection())
            {
                return conn.Execute(@"INSERT INTO [sa_StampOrder] ([sa_StampOrder].[Guid_ID],[sa_StampOrder].[ID],
 [sa_StampOrder].[Code], [sa_StampOrder].[OrderType],
 [sa_StampOrder].[StampUnit], [sa_StampOrder].[cCusCode],
 [sa_StampOrder].[cLinkCode], [sa_StampOrder].[dDate],
 [sa_StampOrder].[dPreDeliDate], [sa_StampOrder].[iTotalCost],
  [sa_StampOrder].[IsInvoice], [sa_StampOrder].[InvoiceID],
   [sa_StampOrder].[Status], [sa_StampOrder].[PrintCode],
    [sa_StampOrder].[IsDeli], [sa_StampOrder].[DeliDept],
     [sa_StampOrder].[LicenseNo], [sa_StampOrder].[DeliAddress],
      [sa_StampOrder].[SourceCode], [sa_StampOrder].[iPrintCount],
       [sa_StampOrder].[Remark], [sa_StampOrder].[CreatedBy],
       [sa_StampOrder].[cDepCode], [sa_StampOrder].[cTeamCode],
        [sa_StampOrder].[CreateDate], [sa_StampOrder].[ModifiedBy],
         [sa_StampOrder].[ModifyDate], [sa_StampOrder].[isElectronic],
          [sa_StampOrder].[VerificationCode], [sa_StampOrder].[CertificateCode],
           [sa_StampOrder].[ErrorReason],
            [sa_StampOrder].[ChargeAmount], [sa_StampOrder].[ZDWHZ])
            VALUES(@Guid_ID, @ID, @Code, @OrderType, @StampUnit, @cCusCode, 
@cLinkCode, @dDate, @dPreDeliDate, @iTotalCost, @IsInvoice, @InvoiceID, @Status, 
@PrintCode, @IsDeli, @DeliDept, @LicenseNo, @DeliAddress, @SourceCode, @iPrintCount, 
@Remark, @CreatedBy, @cDepCode, @cTeamCode, @CreateDate, @ModifiedBy, @ModifyDate, 
@isElectronic, @VerificationCode, @CertificateCode, @ErrorReason, @ChargeAmount, @ZDWHZ)", dInfo);
            }
        }

        /// <summary>
        /// 是否能再开单
        /// </summary>
        /// <param name="teamcode"></param>
        /// <param name="strTime"></param>
        /// <returns></returns>
        public dynamic GetWarning(string teamcode, string strTime)
        {
            using (var conn = GetConnection())
            {
                return conn.Query<dynamic>(@"
                DECLARE @icount INT,@AllowCount INT,@ifactcount INT,@WarningCount INT
                SELECT @icount=0,@WarningCount=0,@AllowCount=0,@ifactcount=0
 
                SELECT @icount=CASE WHEN SUM(CASE WHEN ob.ReceiveDate IS NULL THEN 1 ELSE 0 END)*100/SUM(1)>sw.ScanPer
                       THEN SUM(CASE WHEN ob.ReceiveDate IS NULL THEN 1 ELSE 0 END) ELSE 0 END,
                       @WarningCount=sw.ScanPer,@AllowCount=sw.AllowCount
                  FROM dbo.qc_OutPackBarcode ob
                  JOIN dbo.v_TeamStat ts ON ts.cTeamDefine4=ob.TakeTN
                  JOIN dbo.Sa_StampCreateNewControl sw ON sw.cTeamCode=ts.cTeamCode AND sw.CKScan=1 and sw.ISActive=1
                 WHERE ob.UpdateDate IS NOT NULL
                   AND ob.UpdateDate>=DATEADD(HOUR,-20, @p1) and ob.UpdateDate<dateadd(day,1,DATEADD(HOUR,-20, @p1))
                   AND EXISTS(SELECT 1 FROM dbo.sa_StampBarCode sbc WHERE sbc.PackID=ob.ID AND (sbc.abnormal IS NULL OR sbc.abnormal=0))
                   AND ts.cTeamCode= @p0
                 GROUP BY sw.ScanPer,sw.AllowCount
                 HAVING SUM(1)<>0

                IF @icount=0
                BEGIN
	                SELECT 0 WHERE 1=0
                END
                ELSE
                BEGIN
	                SELECT @ifactcount=COUNT(1) FROM dbo.sa_StampOrder
                     WHERE cTeamCode= @p0 AND CreateDate> @p1 AND Status<>'119'
	                IF @ifactcount>@AllowCount
		                SELECT '已到店印章未扫描完成，今天不能开承接单，请到印章条码查询界面完成印章扫描！' sPrompt
	                ELSE
		                SELECT 0 WHERE 1=0
                END",
                 new
                 {
                     p0 = teamcode,
                     p1 = strTime
                 }).AsList();
            }
        }

        /// <summary>
        /// 通过印章编码获取印章价格
        /// </summary>
        /// <param name="digitalNum"></param>
        /// <returns></returns>
        public double GetRenewalFeeFromElectronicStampBySignCode(string digitalNum)
        {
            using (var conn = GetConnection())
            {
                return Convert.ToDouble(conn.ExecuteScalar(@"SELECT renewalFee FROM dbo.cy_ElectronicStamp WHERE signCode=@p0",
                 new
                 {
                     p0 = digitalNum
                 }));
            }
        }

        public async Task<string> testWSAsync(string sid)
        {
            SealWebServiceSoapClient s = new SealWebServiceSoapClient(SealWebServiceSoapClient.EndpointConfiguration.SealWebServiceSoap);
            string ticket = await s.GetAuthorizationTicketAsync("", "");
            return await s.GetUCSIAsync(ticket, sid);
        }

        public string testWS(string sid)
        {
            SealWebServiceSoapClient s = new SealWebServiceSoapClient(SealWebServiceSoapClient.EndpointConfiguration.SealWebServiceSoap);
            var ticket = Task.Run(() => s.GetAuthorizationTicketAsync("", "")).Result;
            return Task.Run(() => s.GetUCSIAsync(ticket, sid)).Result;
        }

        /// <summary>
        /// 获取印章尺寸
        /// </summary>
        /// <param name="cInvCode"></param>
        /// <returns></returns>
        public dynamic GetStampSize(string cInvCode)
        {
            using (var conn = GetConnection())
            {
                return conn.Query<dynamic>(@"SELECT top 1 dbo.fun_GetSize(cInvDefine2,1) curW,dbo.fun_GetSize(cInvDefine3,1)
curH FROM dbo.Inventory WHERE cInvCode=@pInvCode and cInvCCode not like '0510%'", new { pInvCode = cInvCode }).FirstOrDefault();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="oid"></param>
        /// <param name="signCert"></param>
        /// <param name="encryptCert"></param>
        /// <param name="signCode"></param>
        /// <param name="renewalYears"></param>
        /// <param name="promotionYears"></param>
        /// <param name="preferentialType"></param>
        /// <param name="totalRenewalYears"></param>
        /// <param name="renewalFee"></param>
        /// <param name="validityStartDate"></param>
        /// <param name="validityEndDate"></param>
        /// <param name="statusCode"></param>
        /// <param name="responseMsg"></param>
        /// <returns></returns>
        public int InsertElectronicStamp(string oid, string signCert, string encryptCert, string signCode, int? renewalYears, int? promotionYears, string preferentialType, int? totalRenewalYears, double? renewalFee, string validityStartDate, string validityEndDate, string statusCode, string responseMsg)
        {
            using (var conn = GetConnection())
            {
                int resultCount = conn.Execute(@"insert into cy_ElectronicStamp(oid,signCert,encryptCert,
                signCode,renewalYears,promotionYears,preferentialType,totalRenewalYears,renewalFee,validityStartDate,
                validityEndDate,statusCode,responseMsg)
                values('@p0','{1}','{2}','{3}',{4},{5},'{6}',{7},{8},'{9}','{10}','{11}','{12}')",
    new
    {
        @p0 = oid,
        @p1 = signCert,
        @p2 = encryptCert,
        @p3 = signCode,
        @p4 = renewalYears,
        @p5 = promotionYears,
        @p6 = preferentialType,
        @p7 = totalRenewalYears,
        @p8 = renewalFee,
        @p9 = validityStartDate,
        @p10 = validityEndDate,
        @p11 = statusCode,
        @p12 = responseMsg
    });
                return resultCount;
            }
        }

        /// <summary>
        /// 获取价格
        /// </summary>
        /// <param name="cInvCode"></param>
        /// <param name="digitalNum"></param>
        /// <param name="cInvDefine2"></param>
        /// <param name="cInvDefine3"></param>
        /// <returns></returns>
        public double GetSalesPriceNew(string cInvCode, string digitalNum, string cInvDefine2, string cInvDefine3)
        {
            using (var conn = GetConnection())
            {
                string sql = "EXEC dbo.pro_getSalesPriceNew  @p0,NULL,@p1,@p2,@p3";
                var res = conn.QueryFirst<double>(sql, new { @p0 = cInvCode, @p1 = digitalNum, @p2 = cInvDefine2, @p3 = cInvDefine3 });
                return res;
            }
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="certificateCode"></param>
        /// <returns></returns>
        public int CancelCertificateContent(string certificateCode)
        {
            using (var conn = GetConnection())
            {
                string sql = "update [UFDATA_006_2015].[dbo].[SealCertificateContent] set Status='10' where CertificateCode=@p0";
                var res = conn.QueryFirst<int>(sql, new { @p0 = certificateCode });  //90
                return res;
            }
        }

        /// <summary>
        ///  删除承接单行
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeleteStampItem(int id)
        {
            using (var conn = GetConnection())
            {
                //
                var trans = conn.BeginTransaction();
                string sql1 = @"DELETE FROM  dbo.base_FileTansfer WHERE BName = '承接业务' AND BID = @p0";
                string sql2 = @"DELETE FROM dbo.sa_StampOrders WHERE AutoID = @p0";
                string sql3 = @"DELETE FROM dbo.sa_StampProperties WHERE PID = @p0";
                try
                {
                    int res1 = conn.Execute(sql1, new { p0 = id });
                    int res2 = conn.Execute(sql2, new { p0 = id });
                    int res3 = conn.Execute(sql3, new { p0 = id });
                    trans.Commit();
                    return res1 + res2 + res3;
                }
                catch (Exception ex)
                {
                    LoggHelper.GetInstance().LogError("FileUpLoad", "删除承接单项出错", ex);
                    trans.Rollback();
                    return 0;
                }
            }
        }

        /// <summary>
        /// 通过code获取列表
        /// </summary>
        /// <param name="certificateCode"></param>
        /// <returns></returns>
        public IEnumerable<StampOrderInfo> SelectListByCertCode(string certificateCode)
        {
            using (var conn = GetConnection())
            {
                return conn.Query<StampOrderInfo>(
                    @"select code as ordernum,CertificateCode from 
 [UFDATA_006_2015].[dbo].[sa_StampOrderNew] where CertificateCode=@p0 and Status <>119",
                new
                {
                    @p0 = certificateCode
                }
                );
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="startDay"></param>
        /// <param name="endDay"></param>
        /// <param name="depCode"></param>
        /// <returns></returns>
        public IEnumerable<dynamic> GetSampleSeals(string startDay, string endDay, string depCode)
        {
            string sqlCondition = string.Format(" AND so.dDate>='{0}' AND so.dDate<DATEADD(DAY,1,'{1}')", startDay, endDay);
            if (!string.IsNullOrEmpty(depCode))
                sqlCondition += string.Format(" and (so.cDepCode='{0}' or so.cTeamCode='{0}')", depCode);
            string strSql = string.Format(@"SELECT  CONVERT(NVARCHAR, so.dDate, 23) AS BillDay ,
        CONVERT(NVARCHAR, so.dDate, 24) AS BillTime ,
        so.Code AS BillCode ,
        so.OrderType AS BillType ,
        sos.GoodsName AS GoodsName ,
        sos.cInvDefine2 AS [Length] ,
        sos.cInvDefine3 AS Width ,
        sos.cInvName AS MaterialName ,
        sos.cInvStd AS MaterialSpecifiction ,
        ( SELECT    inv.cInvDefine7
          FROM      Inventory inv
          WHERE     inv.cInvCode = sos.cInvCode
        ) AS Model ,
        sos.iQuantity AS Quantity ,
        so.StampUnit AS CustomerAddress ,
        cus.cCusName AS CustomerName ,
        ts.cDepName AS BillDepartment ,
        ts.cTeamName AS SaleDepartment ,
        CASE WHEN qc.PID IS NULL THEN '否'
             ELSE CASE qc.IsPass
                    WHEN 1 THEN '否'
                    ELSE '是'
                  END
        END AS IsProductAnomaly ,
        qc.UnpassReason AS AnomalyReason
FROM    dbo.sa_StampOrder so
        INNER JOIN sa_StampOrders sos ON so.ID = sos.PID
        LEFT JOIN dbo.Customer cus ON so.cCusCode = cus.cCusCode
        LEFT JOIN dbo.v_TeamStat ts ON ISNULL(so.cTeamCode, so.cDepCode) = ts.cTeamCode
        LEFT JOIN dbo.qc_QualityCheck qc ON sos.AutoID = qc.PID
                            WHERE sos.IsStampTemplate = 1 AND so.Status <>119 {0}", sqlCondition);

            using (var conn = GetConnection())
            {
                return conn.Query<dynamic>(strSql).AsList();
            }
        }

        /// <summary>
        /// 按条件分页查询印章承接单
        /// </summary>
        /// <param name="sovf"></param>
        /// <param name="pageIndex"></param>
        /// <param name="pageSize"></param>
        /// <param name="strSort"></param>
        /// <param name="bAsc"></param>
        /// <returns></returns>
        public IEnumerable<StampOrderInfo> SelectPagedListByFilter(StampOrderVerifyFilter sovf, int pageIndex, int pageSize, out int pageCount, string strSort, bool bAsc)
        {
            //全查询sql
            string allQuerySql = @"
SELECT ID,Code,OrderType,StampUnit,so.cCusCode,ct.cCusName,cLinkCode,cc.cContactName,
  ISNULL(cc.cMobilePhone,'')+';'+ISNULL(cc.cOfficePhone,'') LinkTel,
  dDate,dPreDeliDate,iTotalCost,Status,ISNULL((SELECT StatusName FROM ss_WorkflowSetting 
  WHERE 
  FunModule='承接业务' AND StatusNum=so.Status),'已作废')StatusName,PrintCode,LicenseNo,IsDeli,DeliDept,t1.cTeamDefine6,
  t1.cTeamDefine7,DeliAddress,SourceCode,iPrintCount,Remark,CreatedBy,ui.cPsn_Name,so.cDepCode,
  dep.cDepName,CreateDate,ModifiedBy,ModifyDate,
  (SELECT ISNULL(SUM(iPayCost),0) FROM dbo.sa_PayRecords WHERE BName='承接业务' AND BID=so.ID AND PayType<>'冲红抵扣') 
  PaidCost,(SELECT ISNULL(SUM(iPayCost),0) FROM dbo.sa_PayRecords WHERE BName='承接业务' AND BID=so.ID AND PayType='冲红抵扣') NCDeductible,
  IsInvoice,InvoiceID,so.cTeamCode,t.cTeamName,ISNULL((SELECT IsInvoice FROM sa_InvoiceArchive WHERE ID=so.InvoiceID),0) bInvoice,
  ZDWHZ FROM sa_StampOrder so 
  LEFT JOIN Customer ct ON ct.cCusCode=so.cCusCode 
  LEFT JOIN Crm_Contact cc ON so.cLinkCode=cc.cContactCode 
  LEFT JOIN v_UserInfo ui ON ui.cUser_Name=so.CreatedBy 
  LEFT JOIN Department dep ON so.cDepCode=dep.cDepCode 
  LEFT JOIN v_TeamStat t ON ISNULL(so.cTeamCode,so.cDepCode)=t.cTeamCode 
  LEFT JOIN v_TeamStat t1 ON so.DeliDept=t1.cTeamName /**where**/
            ";
            var builder = new SqlBuilder();
            var selector = builder.AddTemplate(allQuerySql);
            //参照:从frmstamporderverify移植

            builder.Where("1=1");
            // if (!string.IsNullOrEmpty(sovf.tb tbCode)))
            //    strFilter += string.Format(" and Code like '%{0}'", GetTBText(this.tbCode));
            if (!string.IsNullOrEmpty(sovf.OrderType))
            {
                builder.Where("OrderType=@ordertype", new { @ordertype = sovf.OrderType });
            }
            if (!string.IsNullOrEmpty(sovf.CusName))
            {
                builder.Where("cCusName like @cCusName", new { @cCusName = "%" + sovf.CusName + "%" });
            }

            builder.Where("CreateDate between @FromDate and @ToDate",
                new
                {
                    @FromDate = sovf.FromDate ?? DateTime.Parse("1970-01-01"),
                    @ToDate = sovf.ToDate == null ? DateTime.Parse("2999-01-01") : sovf.ToDate.Value.AddDays(1)
                });
            if (!string.IsNullOrEmpty(sovf.Status))
                builder.Where("Status=@Status", new { @Status = sovf.Status });

            if (sovf.IsDebt)//是否欠款?
                builder.Where(" not exists(SELECT 1 FROM dbo.sa_PayRecords pr WHERE pr.BName=@BName AND pr.BID=so.ID HAVING SUM(pr.iPayCost)>=so.iTotalCost)",
                    new { @BName = CY_SystemConsts.FunModule.Stamp });

            if (sovf.ToVoid)//是否作废?
                builder.Where("so.Status<>'119'");

            if (!string.IsNullOrEmpty(sovf.DepCode))
            {
                builder.Where("so.cDepCode=@cDepCode", new { @cDepCode = sovf.DepCode });
                if (!string.IsNullOrEmpty(sovf.TeamName))
                    builder.Where("so.cTeamCode=@cTeamCode", new { @cTeamCode = sovf.TeamName });
            }
            if (!string.IsNullOrEmpty(sovf.StampUnit))
                builder.Where(" StampUnit like @StampUnit", new { @StampUnit = sovf.StampUnit });

            //传值selector的语句
            string pagedSql = SqlStringHelper.ConvertToPagedSQL(selector.RawSql, pageSize, pageIndex, strSort, bAsc);

            using (var conn = GetConnection())
            {
                //返回多结果集
                var multiData = conn.QueryMultiple(pagedSql, selector.Parameters);
                //获取页数
                pageCount = multiData.Read<int>().Single();
                //获取数据集
                var stampOrderList = multiData.Read<StampOrderInfo>();
                //return conn.Query<query<<StampOrdersInfo>(strSql).AsList();
                return stampOrderList;
            }

        }
    }
}
