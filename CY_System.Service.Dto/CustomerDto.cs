using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.Service.Dto
{
    /// <summary>
	/// Customer数据传输实体类
    /// 作者: C
    /// 时间: 2018-01-19 14:32:49
    /// </summary>
    public class CustomerDto
    {
        /// <summary>
        /// cCusCode属性
        /// <summary>
        public string cCusCode { get; set; }

        /// <summary>
        /// cCusName属性
        /// <summary>
        public string cCusName { get; set; }

        /// <summary>
        /// cCusAbbName属性
        /// <summary>
        public string cCusAbbName { get; set; }

        /// <summary>
        /// cCCCode属性
        /// <summary>
        public string cCCCode { get; set; }

        /// <summary>
        /// cDCCode属性
        /// <summary>
        public string cDCCode { get; set; }

        /// <summary>
        /// cTrade属性
        /// <summary>
        public string cTrade { get; set; }

        /// <summary>
        /// cCusAddress属性
        /// <summary>
        public string cCusAddress { get; set; }

        /// <summary>
        /// cCusPostCode属性
        /// <summary>
        public string cCusPostCode { get; set; }

        /// <summary>
        /// cCusRegCode属性
        /// <summary>
        public string cCusRegCode { get; set; }

        /// <summary>
        /// cCusBank属性
        /// <summary>
        public string cCusBank { get; set; }

        /// <summary>
        /// cCusAccount属性
        /// <summary>
        public string cCusAccount { get; set; }

        /// <summary>
        /// dCusDevDate属性
        /// <summary>
        public DateTime? dCusDevDate { get; set; }

        /// <summary>
        /// cCusLPerson属性
        /// <summary>
        public string cCusLPerson { get; set; }

        /// <summary>
        /// cCusEmail属性
        /// <summary>
        public string cCusEmail { get; set; }

        /// <summary>
        /// cCusPerson属性
        /// <summary>
        public string cCusPerson { get; set; }

        /// <summary>
        /// cCusPhone属性
        /// <summary>
        public string cCusPhone { get; set; }

        /// <summary>
        /// cCusFax属性
        /// <summary>
        public string cCusFax { get; set; }

        /// <summary>
        /// cCusBP属性
        /// <summary>
        public string cCusBP { get; set; }

        /// <summary>
        /// cCusHand属性
        /// <summary>
        public string cCusHand { get; set; }

        /// <summary>
        /// cCusPPerson属性
        /// <summary>
        public string cCusPPerson { get; set; }

        /// <summary>
        /// iCusDisRate属性
        /// <summary>
        public double? iCusDisRate { get; set; }

        /// <summary>
        /// cCusCreGrade属性
        /// <summary>
        public string cCusCreGrade { get; set; }

        /// <summary>
        /// iCusCreLine属性
        /// <summary>
        public double? iCusCreLine { get; set; }

        /// <summary>
        /// iCusCreDate属性
        /// <summary>
        public int? iCusCreDate { get; set; }

        /// <summary>
        /// cCusPayCond属性
        /// <summary>
        public string cCusPayCond { get; set; }

        /// <summary>
        /// cCusOAddress属性
        /// <summary>
        public string cCusOAddress { get; set; }

        /// <summary>
        /// cCusOType属性
        /// <summary>
        public string cCusOType { get; set; }

        /// <summary>
        /// cCusHeadCode属性
        /// <summary>
        public string cCusHeadCode { get; set; }

        /// <summary>
        /// cCusWhCode属性
        /// <summary>
        public string cCusWhCode { get; set; }

        /// <summary>
        /// cCusDepart属性
        /// <summary>
        public string cCusDepart { get; set; }

        /// <summary>
        /// iARMoney属性
        /// <summary>
        public double? iARMoney { get; set; }

        /// <summary>
        /// dLastDate属性
        /// <summary>
        public DateTime? dLastDate { get; set; }

        /// <summary>
        /// iLastMoney属性
        /// <summary>
        public double? iLastMoney { get; set; }

        /// <summary>
        /// dLRDate属性
        /// <summary>
        public DateTime? dLRDate { get; set; }

        /// <summary>
        /// iLRMoney属性
        /// <summary>
        public double? iLRMoney { get; set; }

        /// <summary>
        /// dEndDate属性
        /// <summary>
        public DateTime? dEndDate { get; set; }

        /// <summary>
        /// iFrequency属性
        /// <summary>
        public int? iFrequency { get; set; }

        /// <summary>
        /// cCusDefine1属性
        /// <summary>
        public string cCusDefine1 { get; set; }

        /// <summary>
        /// cCusDefine2属性
        /// <summary>
        public string cCusDefine2 { get; set; }

        /// <summary>
        /// cCusDefine3属性
        /// <summary>
        public string cCusDefine3 { get; set; }

        /// <summary>
        /// iCostGrade属性
        /// <summary>
        public int? iCostGrade { get; set; }

        /// <summary>
        /// cCreatePerson属性
        /// <summary>
        public string cCreatePerson { get; set; }

        /// <summary>
        /// cModifyPerson属性
        /// <summary>
        public string cModifyPerson { get; set; }

        /// <summary>
        /// dModifyDate属性
        /// <summary>
        public DateTime? dModifyDate { get; set; }

        /// <summary>
        /// cRelVendor属性
        /// <summary>
        public string cRelVendor { get; set; }

        /// <summary>
        /// iId属性
        /// <summary>
        public string iId { get; set; }

        /// <summary>
        /// cPriceGroup属性
        /// <summary>
        public string cPriceGroup { get; set; }

        /// <summary>
        /// cOfferGrade属性
        /// <summary>
        public string cOfferGrade { get; set; }

        /// <summary>
        /// iOfferRate属性
        /// <summary>
        public double? iOfferRate { get; set; }

        /// <summary>
        /// cCusDefine4属性
        /// <summary>
        public string cCusDefine4 { get; set; }

        /// <summary>
        /// cCusDefine5属性
        /// <summary>
        public string cCusDefine5 { get; set; }

        /// <summary>
        /// cCusDefine6属性
        /// <summary>
        public string cCusDefine6 { get; set; }

        /// <summary>
        /// cCusDefine7属性
        /// <summary>
        public string cCusDefine7 { get; set; }

        /// <summary>
        /// cCusDefine8属性
        /// <summary>
        public string cCusDefine8 { get; set; }

        /// <summary>
        /// cCusDefine9属性
        /// <summary>
        public string cCusDefine9 { get; set; }

        /// <summary>
        /// cCusDefine10属性
        /// <summary>
        public string cCusDefine10 { get; set; }

        /// <summary>
        /// cCusDefine11属性
        /// <summary>
        public int? cCusDefine11 { get; set; }

        /// <summary>
        /// cCusDefine12属性
        /// <summary>
        public int? cCusDefine12 { get; set; }

        /// <summary>
        /// cCusDefine13属性
        /// <summary>
        public double? cCusDefine13 { get; set; }

        /// <summary>
        /// cCusDefine14属性
        /// <summary>
        public double? cCusDefine14 { get; set; }

        /// <summary>
        /// cCusDefine15属性
        /// <summary>
        public DateTime? cCusDefine15 { get; set; }

        /// <summary>
        /// cCusDefine16属性
        /// <summary>
        public DateTime? cCusDefine16 { get; set; }

        /// <summary>
        /// pubufts属性
        /// <summary>
        public string pubufts { get; set; }

        /// <summary>
        /// cInvoiceCompany属性
        /// <summary>
        public string cInvoiceCompany { get; set; }

        /// <summary>
        /// bCredit属性
        /// <summary>
        public bool? bCredit { get; set; }

        /// <summary>
        /// bCreditDate属性
        /// <summary>
        public bool? bCreditDate { get; set; }

        /// <summary>
        /// bCreditByHead属性
        /// <summary>
        public bool? bCreditByHead { get; set; }

        /// <summary>
        /// bLicenceDate属性
        /// <summary>
        public bool? bLicenceDate { get; set; }

        /// <summary>
        /// dLicenceSDate属性
        /// <summary>
        public DateTime? dLicenceSDate { get; set; }

        /// <summary>
        /// dLicenceEDate属性
        /// <summary>
        public DateTime? dLicenceEDate { get; set; }

        /// <summary>
        /// iLicenceADays属性
        /// <summary>
        public int? iLicenceADays { get; set; }

        /// <summary>
        /// bBusinessDate属性
        /// <summary>
        public bool? bBusinessDate { get; set; }

        /// <summary>
        /// dBusinessSDate属性
        /// <summary>
        public DateTime? dBusinessSDate { get; set; }

        /// <summary>
        /// dBusinessEDate属性
        /// <summary>
        public DateTime? dBusinessEDate { get; set; }

        /// <summary>
        /// iBusinessADays属性
        /// <summary>
        public int? iBusinessADays { get; set; }

        /// <summary>
        /// bProxy属性
        /// <summary>
        public bool? bProxy { get; set; }

        /// <summary>
        /// dProxySDate属性
        /// <summary>
        public DateTime? dProxySDate { get; set; }

        /// <summary>
        /// dProxyEDate属性
        /// <summary>
        public DateTime? dProxyEDate { get; set; }

        /// <summary>
        /// iProxyADays属性
        /// <summary>
        public int? iProxyADays { get; set; }

        /// <summary>
        /// cMemo属性
        /// <summary>
        public string cMemo { get; set; }

        /// <summary>
        /// bLimitSale属性
        /// <summary>
        public bool? bLimitSale { get; set; }

        /// <summary>
        /// cCusContactCode属性
        /// <summary>
        public Guid? cCusContactCode { get; set; }

        /// <summary>
        /// cCusCountryCode属性
        /// <summary>
        public string cCusCountryCode { get; set; }

        /// <summary>
        /// cCusEnName属性
        /// <summary>
        public string cCusEnName { get; set; }

        /// <summary>
        /// cCusEnAddr1属性
        /// <summary>
        public string cCusEnAddr1 { get; set; }

        /// <summary>
        /// cCusEnAddr2属性
        /// <summary>
        public string cCusEnAddr2 { get; set; }

        /// <summary>
        /// cCusEnAddr3属性
        /// <summary>
        public string cCusEnAddr3 { get; set; }

        /// <summary>
        /// cCusEnAddr4属性
        /// <summary>
        public string cCusEnAddr4 { get; set; }

        /// <summary>
        /// cCusPortCode属性
        /// <summary>
        public string cCusPortCode { get; set; }

        /// <summary>
        /// cPrimaryVen属性
        /// <summary>
        public string cPrimaryVen { get; set; }

        /// <summary>
        /// fCommisionRate属性
        /// <summary>
        public double? fCommisionRate { get; set; }

        /// <summary>
        /// fInsueRate属性
        /// <summary>
        public double? fInsueRate { get; set; }

        /// <summary>
        /// bHomeBranch属性
        /// <summary>
        public bool? bHomeBranch { get; set; }

        /// <summary>
        /// cBranchAddr属性
        /// <summary>
        public string cBranchAddr { get; set; }

        /// <summary>
        /// cBranchPhone属性
        /// <summary>
        public string cBranchPhone { get; set; }

        /// <summary>
        /// cBranchPerson属性
        /// <summary>
        public string cBranchPerson { get; set; }

        /// <summary>
        /// cCusTradeCCode属性
        /// <summary>
        public string cCusTradeCCode { get; set; }

        /// <summary>
        /// CustomerKCode属性
        /// <summary>
        public string CustomerKCode { get; set; }

        /// <summary>
        /// bCusState属性
        /// <summary>
        public bool? bCusState { get; set; }

        /// <summary>
        /// bShop属性
        /// <summary>
        public int? bShop { get; set; }

        /// <summary>
        /// cCusBankCode属性
        /// <summary>
        public string cCusBankCode { get; set; }

        /// <summary>
        /// cCusExch_name属性
        /// <summary>
        public string cCusExch_name { get; set; }

        /// <summary>
        /// iCusGSPType属性
        /// <summary>
        public int? iCusGSPType { get; set; }

        /// <summary>
        /// iCusGSPAuth属性
        /// <summary>
        public int? iCusGSPAuth { get; set; }

        /// <summary>
        /// cCusGSPAuthNo属性
        /// <summary>
        public string cCusGSPAuthNo { get; set; }

        /// <summary>
        /// cCusBusinessNo属性
        /// <summary>
        public string cCusBusinessNo { get; set; }

        /// <summary>
        /// cCusLicenceNo属性
        /// <summary>
        public string cCusLicenceNo { get; set; }

        /// <summary>
        /// bCusDomestic属性
        /// <summary>
        public bool? bCusDomestic { get; set; }

        /// <summary>
        /// bCusOverseas属性
        /// <summary>
        public bool? bCusOverseas { get; set; }

        /// <summary>
        /// cCusCreditCompany属性
        /// <summary>
        public string cCusCreditCompany { get; set; }

        /// <summary>
        /// cCusSAProtocol属性
        /// <summary>
        public string cCusSAProtocol { get; set; }

        /// <summary>
        /// cCusExProtocol属性
        /// <summary>
        public string cCusExProtocol { get; set; }

        /// <summary>
        /// cCusOtherProtocol属性
        /// <summary>
        public string cCusOtherProtocol { get; set; }

        /// <summary>
        /// fCusDiscountRate属性
        /// <summary>
        public double? fCusDiscountRate { get; set; }

        /// <summary>
        /// cCusSSCode属性
        /// <summary>
        public string cCusSSCode { get; set; }

        /// <summary>
        /// cCusCMProtocol属性
        /// <summary>
        public string cCusCMProtocol { get; set; }

        /// <summary>
        /// dCusCreateDatetime属性
        /// <summary>
        public DateTime? dCusCreateDatetime { get; set; }

        /// <summary>
        /// cCusAppDocNo属性
        /// <summary>
        public string cCusAppDocNo { get; set; }

        /// <summary>
        /// cCusMnemCode属性
        /// <summary>
        public string cCusMnemCode { get; set; }

        /// <summary>
        /// fAdvancePaymentRatio属性
        /// <summary>
        public double? fAdvancePaymentRatio { get; set; }

        /// <summary>
        /// bServiceAttribute属性
        /// <summary>
        public bool? bServiceAttribute { get; set; }

        /// <summary>
        /// bRequestSign属性
        /// <summary>
        public bool? bRequestSign { get; set; }

        /// <summary>
        /// bOnGPinStore属性
        /// <summary>
        public bool? bOnGPinStore { get; set; }

        /// <summary>
        /// cCusMngTypeCode属性
        /// <summary>
        public string cCusMngTypeCode { get; set; }

        /// <summary>
        /// account_type属性
        /// <summary>
        public decimal? account_type { get; set; }

        /// <summary>
        /// cCusImAgentProtocol属性
        /// <summary>
        public string cCusImAgentProtocol { get; set; }

        /// <summary>
        /// iSourceType属性
        /// <summary>
        public int? iSourceType { get; set; }

        /// <summary>
        /// iSourceId属性
        /// <summary>
        public string iSourceId { get; set; }

        /// <summary>
        /// fExpense属性
        /// <summary>
        public double? fExpense { get; set; }

        /// <summary>
        /// fApprovedExpense属性
        /// <summary>
        public double? fApprovedExpense { get; set; }

        /// <summary>
        /// dTouchedTime属性
        /// <summary>
        public DateTime? dTouchedTime { get; set; }

        /// <summary>
        /// dRecentlyInvoiceTime属性
        /// <summary>
        public DateTime? dRecentlyInvoiceTime { get; set; }

        /// <summary>
        /// dRecentlyQuoteTime属性
        /// <summary>
        public DateTime? dRecentlyQuoteTime { get; set; }

        /// <summary>
        /// dRecentlyActivityTime属性
        /// <summary>
        public DateTime? dRecentlyActivityTime { get; set; }

        /// <summary>
        /// dRecentlyChanceTime属性
        /// <summary>
        public DateTime? dRecentlyChanceTime { get; set; }

        /// <summary>
        /// dRecentlyContractTime属性
        /// <summary>
        public DateTime? dRecentlyContractTime { get; set; }

        /// <summary>
        /// cLtcCustomerCode属性
        /// <summary>
        public string cLtcCustomerCode { get; set; }

        /// <summary>
        /// bTransFlag属性
        /// <summary>
        public bool? bTransFlag { get; set; }

        /// <summary>
        /// cLtcPerson属性
        /// <summary>
        public string cLtcPerson { get; set; }

        /// <summary>
        /// dLtcDate属性
        /// <summary>
        public DateTime? dLtcDate { get; set; }

        /// <summary>
        /// cLocationSite属性
        /// <summary>
        public string cLocationSite { get; set; }

        /// <summary>
        /// iCusTaxRate属性
        /// <summary>
        public double? iCusTaxRate { get; set; }

        /// <summary>
        /// alloct_dept_time属性
        /// <summary>
        public DateTime? alloct_dept_time { get; set; }

        /// <summary>
        /// allot_user_time属性
        /// <summary>
        public DateTime? allot_user_time { get; set; }

        /// <summary>
        /// recyle_dept_time属性
        /// <summary>
        public DateTime? recyle_dept_time { get; set; }

        /// <summary>
        /// recyle_pub_time属性
        /// <summary>
        public DateTime? recyle_pub_time { get; set; }

        /// <summary>
        /// cLicenceNo属性
        /// <summary>
        public string cLicenceNo { get; set; }

        /// <summary>
        /// cLicenceRange属性
        /// <summary>
        public string cLicenceRange { get; set; }

        /// <summary>
        /// cCusBusinessRange属性
        /// <summary>
        public string cCusBusinessRange { get; set; }

        /// <summary>
        /// cCusGSPAuthRange属性
        /// <summary>
        public string cCusGSPAuthRange { get; set; }

        /// <summary>
        /// dCusGSPEDate属性
        /// <summary>
        public DateTime? dCusGSPEDate { get; set; }

        /// <summary>
        /// dCusGSPSDate属性
        /// <summary>
        public DateTime? dCusGSPSDate { get; set; }

        /// <summary>
        /// iCusGSPADays属性
        /// <summary>
        public int? iCusGSPADays { get; set; }

        /// <summary>
        /// bIsCusAttachFile属性
        /// <summary>
        public bool? bIsCusAttachFile { get; set; }

        /// <summary>
        /// dRecentContractDate属性
        /// <summary>
        public DateTime? dRecentContractDate { get; set; }

        /// <summary>
        /// dRecentDeliveryDate属性
        /// <summary>
        public DateTime? dRecentDeliveryDate { get; set; }

        /// <summary>
        /// dRecentOutboundDate属性
        /// <summary>
        public DateTime? dRecentOutboundDate { get; set; }


    }
}


