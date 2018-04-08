using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.DomainStandard
{
    /// <summary>
	/// Note实体类
    /// 作者: C
    /// 时间: 2018-01-15 19:23:28
    /// </summary>
    [POCO(DbConnName = CY_SystemConsts.ConnectionString_conn, TableName = "Ap_Note")]
    public class NoteInfo
    {
        /// <summary>
        /// Auto_ID属性
        /// <summary>
        public int? Auto_ID { get; set; }

        /// <summary>
        /// cLink属性
        /// <summary>
        public string cLink { get; set; }

        /// <summary>
        /// cVouchType属性
        /// <summary>
        public string cVouchType { get; set; }

        /// <summary>
        /// cVouchID属性
        /// <summary>
        public string cVouchID { get; set; }

        /// <summary>
        /// cBank属性
        /// <summary>
        public string cBank { get; set; }

        /// <summary>
        /// cDwCode属性
        /// <summary>
        public string cDwCode { get; set; }

        /// <summary>
        /// cDeptCode属性
        /// <summary>
        public string cDeptCode { get; set; }

        /// <summary>
        /// cPerson属性
        /// <summary>
        public string cPerson { get; set; }

        /// <summary>
        /// cItem_Class属性
        /// <summary>
        public string cItem_Class { get; set; }

        /// <summary>
        /// cItemCode属性
        /// <summary>
        public string cItemCode { get; set; }

        /// <summary>
        /// cDigest属性
        /// <summary>
        public string cDigest { get; set; }

        /// <summary>
        /// cCode属性
        /// <summary>
        public string cCode { get; set; }

        /// <summary>
        /// iAmount属性
        /// <summary>
        public double? iAmount { get; set; }

        /// <summary>
        /// iRate属性
        /// <summary>
        public double? iRate { get; set; }

        /// <summary>
        /// iRAmount属性
        /// <summary>
        public double? iRAmount { get; set; }

        /// <summary>
        /// cEndorser属性
        /// <summary>
        public string cEndorser { get; set; }

        /// <summary>
        /// iEndorAmount属性
        /// <summary>
        public double? iEndorAmount { get; set; }

        /// <summary>
        /// dSignDate属性
        /// <summary>
        public DateTime? dSignDate { get; set; }

        /// <summary>
        /// dExpireDate属性
        /// <summary>
        public DateTime? dExpireDate { get; set; }

        /// <summary>
        /// dReceiptDate属性
        /// <summary>
        public DateTime? dReceiptDate { get; set; }

        /// <summary>
        /// cOperator属性
        /// <summary>
        public string cOperator { get; set; }

        /// <summary>
        /// bStartFlag属性
        /// <summary>
        public bool? bStartFlag { get; set; }

        /// <summary>
        /// cFlag属性
        /// <summary>
        public string cFlag { get; set; }

        /// <summary>
        /// iCloseID属性
        /// <summary>
        public int? iCloseID { get; set; }

        /// <summary>
        /// VT_ID属性
        /// <summary>
        public int? VT_ID { get; set; }

        /// <summary>
        /// Ufts属性
        /// <summary>
        //public string Ufts { get; set; }

        /// <summary>
        /// cItemName属性
        /// <summary>
        public string cItemName { get; set; }

        /// <summary>
        /// cReceiver属性
        /// <summary>
        public string cReceiver { get; set; }

        /// <summary>
        /// cReceiveBank属性
        /// <summary>
        public string cReceiveBank { get; set; }

        /// <summary>
        /// cReceiveAccount属性
        /// <summary>
        public string cReceiveAccount { get; set; }

        /// <summary>
        /// iEndorAmount_Local属性
        /// <summary>
        public double? iEndorAmount_Local { get; set; }

        /// <summary>
        /// iAmount_Local属性
        /// <summary>
        public double? iAmount_Local { get; set; }

        /// <summary>
        /// iRAmount_Local属性
        /// <summary>
        public double? iRAmount_Local { get; set; }

        /// <summary>
        /// cSettleCode属性
        /// <summary>
        public string cSettleCode { get; set; }

        /// <summary>
        /// cBill属性
        /// <summary>
        public string cBill { get; set; }

        /// <summary>
        /// cSuperBank属性
        /// <summary>
        public string cSuperBank { get; set; }

        /// <summary>
        /// cexch_name属性
        /// <summary>
        public string cexch_name { get; set; }

        /// <summary>
        /// cEndorserName属性
        /// <summary>
        public string cEndorserName { get; set; }

        /// <summary>
        /// cDWName属性
        /// <summary>
        public string cDWName { get; set; }

        /// <summary>
        /// cPayBillAccount属性
        /// <summary>
        public string cPayBillAccount { get; set; }

        /// <summary>
        /// cPayBillBankID属性
        /// <summary>
        public string cPayBillBankID { get; set; }

        /// <summary>
        /// cPayBillBankAdress属性
        /// <summary>
        public string cPayBillBankAdress { get; set; }

        /// <summary>
        /// dPayExpireDate属性
        /// <summary>
        public DateTime? dPayExpireDate { get; set; }

        /// <summary>
        /// dProxyPayBank属性
        /// <summary>
        public string dProxyPayBank { get; set; }

        /// <summary>
        /// dProxyPayBankID属性
        /// <summary>
        public string dProxyPayBankID { get; set; }

        /// <summary>
        /// cRemitAdress属性
        /// <summary>
        public string cRemitAdress { get; set; }

        /// <summary>
        /// cReceiverCode属性
        /// <summary>
        public string cReceiverCode { get; set; }

        /// <summary>
        /// cReceiveBankID属性
        /// <summary>
        public string cReceiveBankID { get; set; }

        /// <summary>
        /// cReceiveAdress属性
        /// <summary>
        public string cReceiveAdress { get; set; }

        /// <summary>
        /// cPurpose属性
        /// <summary>
        public string cPurpose { get; set; }

        /// <summary>
        /// cPayMode属性
        /// <summary>
        public string cPayMode { get; set; }

        /// <summary>
        /// dTransferDate属性
        /// <summary>
        public DateTime? dTransferDate { get; set; }

        /// <summary>
        /// iSettleAmount属性
        /// <summary>
        public double? iSettleAmount { get; set; }

        /// <summary>
        /// iOverAmount属性
        /// <summary>
        public double? iOverAmount { get; set; }

        /// <summary>
        /// cCompactID属性
        /// <summary>
        public string cCompactID { get; set; }

        /// <summary>
        /// cPayAddress属性
        /// <summary>
        public string cPayAddress { get; set; }

        /// <summary>
        /// cAgreementID属性
        /// <summary>
        public string cAgreementID { get; set; }

        /// <summary>
        /// cSendDesc属性
        /// <summary>
        public string cSendDesc { get; set; }

        /// <summary>
        /// iAccessories属性
        /// <summary>
        public int? iAccessories { get; set; }

        /// <summary>
        /// cConsignPayee属性
        /// <summary>
        public string cConsignPayee { get; set; }

        /// <summary>
        /// cRemark属性
        /// <summary>
        public string cRemark { get; set; }

        /// <summary>
        /// cAPDesc属性
        /// <summary>
        public string cAPDesc { get; set; }

        /// <summary>
        /// nfrat属性
        /// <summary>
        public double? nfrat { get; set; }

        /// <summary>
        /// cDefine1属性
        /// <summary>
        public string cDefine1 { get; set; }

        /// <summary>
        /// cDefine2属性
        /// <summary>
        public string cDefine2 { get; set; }

        /// <summary>
        /// cDefine3属性
        /// <summary>
        public string cDefine3 { get; set; }

        /// <summary>
        /// cDefine4属性
        /// <summary>
        public DateTime? cDefine4 { get; set; }

        /// <summary>
        /// cDefine5属性
        /// <summary>
        public int? cDefine5 { get; set; }

        /// <summary>
        /// cDefine6属性
        /// <summary>
        public DateTime? cDefine6 { get; set; }

        /// <summary>
        /// cDefine7属性
        /// <summary>
        public double? cDefine7 { get; set; }

        /// <summary>
        /// cDefine8属性
        /// <summary>
        public string cDefine8 { get; set; }

        /// <summary>
        /// cDefine9属性
        /// <summary>
        public string cDefine9 { get; set; }

        /// <summary>
        /// cDefine10属性
        /// <summary>
        public string cDefine10 { get; set; }

        /// <summary>
        /// cDefine11属性
        /// <summary>
        public string cDefine11 { get; set; }

        /// <summary>
        /// cDefine12属性
        /// <summary>
        public string cDefine12 { get; set; }

        /// <summary>
        /// cDefine13属性
        /// <summary>
        public string cDefine13 { get; set; }

        /// <summary>
        /// cDefine14属性
        /// <summary>
        public string cDefine14 { get; set; }

        /// <summary>
        /// cDefine15属性
        /// <summary>
        public int? cDefine15 { get; set; }

        /// <summary>
        /// cDefine16属性
        /// <summary>
        public double? cDefine16 { get; set; }

        /// <summary>
        /// iVT_ID属性
        /// <summary>
        public int? iVT_ID { get; set; }

        /// <summary>
        /// dcreatesystime属性
        /// <summary>
        public DateTime? dcreatesystime { get; set; }

        /// <summary>
        /// dverifysystime属性
        /// <summary>
        public DateTime? dverifysystime { get; set; }

        /// <summary>
        /// dmodifysystime属性
        /// <summary>
        public DateTime? dmodifysystime { get; set; }

        /// <summary>
        /// cmodifier属性
        /// <summary>
        public string cmodifier { get; set; }

        /// <summary>
        /// dmoddate属性
        /// <summary>
        public DateTime? dmoddate { get; set; }

        /// <summary>
        /// dverifydate属性
        /// <summary>
        public DateTime? dverifydate { get; set; }

        /// <summary>
        /// iPrintCount属性
        /// <summary>
        public int? iPrintCount { get; set; }

        /// <summary>
        /// lAcctID属性
        /// <summary>
        public int? lAcctID { get; set; }

        /// <summary>
        /// csysbarcode属性
        /// <summary>
        public string csysbarcode { get; set; }

        /// <summary>
        /// bSecurityDeposit属性
        /// <summary>
        public bool? bSecurityDeposit { get; set; }

        /// <summary>
        /// lAcctID_BZJ属性
        /// <summary>
        public int? lAcctID_BZJ { get; set; }

        /// <summary>
        /// iChangeType属性
        /// <summary>
        public int? iChangeType { get; set; }

        /// <summary>
        /// cChanger属性
        /// <summary>
        public string cChanger { get; set; }

        /// <summary>
        /// cchangerName属性
        /// <summary>
        public string cchangerName { get; set; }

        /// <summary>
        /// dChangedate属性
        /// <summary>
        public DateTime? dChangedate { get; set; }

        /// <summary>
        /// iReceiveAmount属性
        /// <summary>
        public double? iReceiveAmount { get; set; }

        /// <summary>
        /// iReceiveAmount_Local属性
        /// <summary>
        public double? iReceiveAmount_Local { get; set; }


    }
}

