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
    /// SealCertificateContent仓库,该段代码由代码生成器自动生成
    /// 作者: C
    /// 时间: 2018-01-18 15:42:02
    /// </summary>
    public class SealCertificateContentRepository : BaseRepository<SealCertificateContentInfo>
    {
        //ToDo:具体的对数据库实现的方法写在这里
        public SealCertificateContentInfo SelectModelByCode(string code)
        {
            using (var conn = GetConnection())
            {

                StringBuilder strSql = new StringBuilder();
                strSql.Append(@"select ID,CertificateCode,CusName,BusLicence,CorporateCard,RegiCard,OperateCard,AccountCard,PersonCertificate,RegiForeCard,EnterpriseCertificate,OldSigNum,BGDoc,Other,HandleType,LinkMan,LinkTel,LinkEmail,Handle,HandleOffice,EnterTel,PickYear,PickMonth,PickDay,TolPay,CurPay,UnPay,PayType,Status,CreateBy,CreateDate,VerificationCode,cDepCode,cTeamCode,Remark,cCusCode,UnitCus,DeliDept,ModifyBy,ModifyDate from SealCertificateContent ");
                strSql.Append(@" where CertificateCode=@p0");

                return conn.QueryFirst<SealCertificateContentInfo>(strSql.ToString(), new { p0 = code });
            }
        }

        public void UpdatePZCode(string pzcodeText)
        {
            using (var conn = GetConnection())
            {

                string sql = "update[UFDATA_006_2015].[dbo].[SealCertificateContent] set Status = '20' where CertificateCode = @p0";
                conn.Execute(sql.ToString(), new { p0 = pzcodeText });
            }
        }
    }
}
