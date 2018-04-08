using System.Collections.Generic;
using System.Runtime.Serialization;
using System;

namespace CY_System.Service.Dto
{
    /// <summary>
    /// </summary>
    public class YzzbData
    {
        /// <summary>
        /// 2017-09-29 11:00:34
        /// </summary>
        public DateTime applyDate { get; set; }
        /// <summary>
        /// 2017-09-29 11:00:34
        /// </summary>
        public DateTime auditDate { get; set; }
        /// <summary>
        /// 01
        /// </summary>
        public string centerDesign { get; set; }
        /// <summary>
        /// CheckDate
        /// </summary>
        public string checkDate { get; set; }
        /// <summary>
        /// ChipId
        /// </summary>
        public string chipId { get; set; }
        /// <summary>
        /// 2017-09-29 11:00:34
        /// </summary>
        public DateTime createTime { get; set; }
        /// <summary>
        /// CreateUserId
        /// </summary>
        public string createUserId { get; set; }
        /// <summary>
        /// DeliverDate
        /// </summary>
        public string deliverDate { get; set; }
        /// <summary>
        /// DigitalNumber
        /// </summary>
        public bool digitalNumber { get; set; }
        /// <summary>
        /// DisableDate
        /// </summary>
        public string disableDate { get; set; }
        /// <summary>
        /// DisableType
        /// </summary>
        public string disableType { get; set; }
        /// <summary>
        /// EdgeWidth
        /// </summary>
        public double edgeWidth { get; set; }
        /// <summary>
        /// Height
        /// </summary>
        public double height { get; set; }
        /// <summary>
        /// 4403030467311
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 0
        /// </summary>
        public string inspectMark { get; set; }
        /// <summary>
        /// InspectRemark
        /// </summary>
        public string inspectRemark { get; set; }
        /// <summary>
        /// 02
        /// </summary>
        public string material { get; set; }
        /// <summary>
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 0
        /// </summary>
        public string processSign { get; set; }
        /// <summary>
        /// ProduceDate
        /// </summary>
        public string produceDate { get; set; }
        /// <summary>
        /// ProduceTransSign
        /// </summary>
        public string produceTransSign { get; set; }
        /// <summary>
        /// 440304990098
        /// </summary>
        public string produceUnitId { get; set; }
        /// <summary>
        /// SecurityLine
        /// </summary>
        public bool securityLine { get; set; }
        /// <summary>
        /// 02
        /// </summary>
        public string shape { get; set; }
        /// <summary>
        /// 2
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// SyncFlag
        /// </summary>
        public string syncFlag { get; set; }
        /// <summary>
        /// 01
        /// </summary>
        public string textComparison { get; set; }
        /// <summary>
        /// 06
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 2017-09-29 11:00:34
        /// </summary>
        public DateTime undertakeDate { get; set; }
        /// <summary>
        /// UndertakeUnitId
        /// </summary>
        public string undertakeUnitId { get; set; }
        /// <summary>
        /// 2017-09-29 11:00:34
        /// </summary>
        public DateTime updateTime { get; set; }
        /// <summary>
        /// UpdateUserId
        /// </summary>
        public string updateUserId { get; set; }
        /// <summary>
        /// 440303207062
        /// </summary>
        public string useUnitId { get; set; }
        /// <summary>
        /// Width
        /// </summary>
        public int width { get; set; }
    }

    public class sealYzzbInfo
    {
        /// <summary>
        /// Code
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// Data
        /// </summary>
        public YzzbData data { get; set; }
        /// <summary>
        /// success!
        /// </summary>
        public string msg { get; set; }
    }

    public class UnitInfoData
    { 
        /// <summary>
        /// 深圳市罗湖区南湖街道人民南路熙龙大厦裙楼一楼2043号商铺
        /// </summary>
        public string address { get; set; }
        /// <summary>
        /// szlhfj
        /// </summary>
        public string areaCode { get; set; }
        /// <summary>
        /// 440300202031508
        /// </summary>
        public string businessLicenseNumber { get; set; }
        /// <summary>
        /// 2017-08-08 12:24:18
        /// </summary>
        public DateTime createTime { get; set; }
        /// <summary>
        /// CreateUserId
        /// </summary>
        public string createUserId { get; set; }
        /// <summary>
        /// EstablishmentDate
        /// </summary>
        public string establishmentDate { get; set; }
        /// <summary>
        /// HeadOfficeId
        /// </summary>
        public string headOfficeId { get; set; }
        /// <summary>
        /// 440303206952
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 440301199202255534
        /// </summary>
        public string idcardNumber { get; set; }
        /// <summary>
        /// 11
        /// </summary>
        public string idcardType { get; set; }
        /// <summary>
        /// IndustryType
        /// </summary>
        public string industryType { get; set; }
        /// <summary>
        /// 深圳市南山区粤海中一路测试地址11门牌
        /// </summary>
        public string legalAddress { get; set; }
        /// <summary>
        /// 邓翔
        /// </summary>
        public string legalName { get; set; }
        /// <summary>
        /// 深圳市永利港式茶餐厅连锁有限公司
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// NameEnglish
        /// </summary>
        public string nameEnglish { get; set; }
        /// <summary>
        /// NameMinorityNationality
        /// </summary>
        public string nameMinorityNationality { get; set; }
        /// <summary>
        /// 01
        /// </summary>
        public string nature { get; set; }
        /// <summary>
        /// MA5ENGWQ4
        /// </summary>
        public string organizationCode { get; set; }
        /// <summary>
        /// 15817463508
        /// </summary>
        public string phone { get; set; }
        /// <summary>
        /// RegisterCardNumber
        /// </summary>
        public string registerCardNumber { get; set; }
        /// <summary>
        /// Remark
        /// </summary>
        public string remark { get; set; }
        /// <summary>
        /// Scale
        /// </summary>
        public string scale { get; set; }
        /// <summary>
        /// 2
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// SyncFlag
        /// </summary>
        public string syncFlag { get; set; }
        /// <summary>
        /// 0
        /// </summary>
        public string taxNumber { get; set; }
        /// <summary>
        /// 15817463508
        /// </summary>
        public string telephone { get; set; }
        /// <summary>
        /// 02
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 91440300MA5ENGWQ4N
        /// </summary>
        public string uniformSocialCreditCode { get; set; }
        /// <summary>
        /// UpdateTime
        /// </summary>
        public string updateTime { get; set; }
        /// <summary>
        /// UpdateUserId
        /// </summary>
        public string updateUserId { get; set; }
    }

    public class UnitInfo
    {
        /// <summary>
        /// AllCount
        /// </summary>
        public int allCount { get; set; }
        /// <summary>
        /// Code
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// Data
        /// </summary>
        public UnitInfoData data { get; set; }
        /// <summary>
        /// success!
        /// </summary>
        public string msg { get; set; }
        /// <summary>
        /// PageCount
        /// </summary>
        public int pageCount { get; set; }
        /// <summary>
        /// PageNum
        /// </summary>
        public int pageNum { get; set; }
        /// <summary>
        /// PageSize
        /// </summary>
        public int pageSize { get; set; }
    }

    public class SealListData
    {
        /// <summary>
        /// 2017-08-24 00:00:00
        /// </summary>
        public DateTime applyDate { get; set; }
        /// <summary>
        /// 2017-08-24 00:00:00
        /// </summary>
        public DateTime auditDate { get; set; }
        /// <summary>
        /// 01
        /// </summary>
        public string centerDesign { get; set; }
        /// <summary>
        /// CheckDate
        /// </summary>
        public string checkDate { get; set; }
        /// <summary>
        /// ChipId
        /// </summary>
        public string chipId { get; set; }
        /// <summary>
        /// 2017-08-24 00:00:00
        /// </summary>
        public DateTime createTime { get; set; }
        /// <summary>
        /// CreateUserId
        /// </summary>
        public string createUserId { get; set; }
        /// <summary>
        /// DeliverDate
        /// </summary>
        public string deliverDate { get; set; }
        /// <summary>
        /// DigitalNumber
        /// </summary>
        public bool digitalNumber { get; set; }
        /// <summary>
        /// DisableDate
        /// </summary>
        public string disableDate { get; set; }
        /// <summary>
        /// DisableType
        /// </summary>
        public string disableType { get; set; }
        /// <summary>
        /// EdgeWidth
        /// </summary>
        public double edgeWidth { get; set; }
        /// <summary>
        /// Height
        /// </summary>
        public double height { get; set; }
        /// <summary>
        /// 4403030467316
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 0
        /// </summary>
        public string inspectMark { get; set; }
        /// <summary>
        /// InspectRemark
        /// </summary>
        public string inspectRemark { get; set; }
        /// <summary>
        /// Material
        /// </summary>
        public string material { get; set; }
        /// <summary>
        /// 发票专用章
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 0
        /// </summary>
        public string processSign { get; set; }
        /// <summary>
        /// ProduceDate
        /// </summary>
        public string produceDate { get; set; }
        /// <summary>
        /// ProduceTransSign
        /// </summary>
        public string produceTransSign { get; set; }
        /// <summary>
        /// ProduceUnitId
        /// </summary>
        public string produceUnitId { get; set; }
        /// <summary>
        /// SecurityLine
        /// </summary>
        public bool securityLine { get; set; }
        /// <summary>
        /// 02
        /// </summary>
        public string shape { get; set; }
        /// <summary>
        /// 1
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// SyncFlag
        /// </summary>
        public string syncFlag { get; set; }
        /// <summary>
        /// 01
        /// </summary>
        public string textComparison { get; set; }
        /// <summary>
        /// 03
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// UndertakeDate
        /// </summary>
        public string undertakeDate { get; set; }
        /// <summary>
        /// UndertakeUnitId
        /// </summary>
        public string undertakeUnitId { get; set; }
        /// <summary>
        /// 2017-08-24 14:28:14
        /// </summary>
        public DateTime updateTime { get; set; }
        /// <summary>
        /// UpdateUserId
        /// </summary>
        public string updateUserId { get; set; }
        /// <summary>
        /// 440303221949
        /// </summary>
        public string useUnitId { get; set; }
        /// <summary>
        /// Width
        /// </summary>
        public int width { get; set; }
    }

    public class SealListInfo
    {
        /// <summary>
        /// Code
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// Data
        /// </summary>
        public List<SealListData> data { get; set; }
        /// <summary>
        /// success!
        /// </summary>
        public string msg { get; set; }
    }

    public class SealDateInfo
    {
        public string code { get; set; }
        public List<SealUndertakeDate> data { get; set; }
        public string msg { get; set; }
    }

    public class SealUndertakeDate
    {
        public string sealId { get; set; }
        public string undertakeDate { get; set; }
    }

    public class DigitalStampInfo
    {
        /// <summary>
        /// Code
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// Data
        /// </summary>
        public List<string> data { get; set; }
        /// <summary>
        /// success!
        /// </summary>
        public string msg { get; set; }
    }

    public class ProcessSealInfo
    {
        /// <summary>
        /// Code
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// Data
        /// </summary>
        public string data { get; set; }
        /// <summary>
        /// success!
        /// </summary>
        public string msg { get; set; }
    }




    public class getSealCompanyDetailData
    {
        /// <summary>
        /// Id
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 440304990001
        /// </summary>
        public string code { get; set; }
        /// <summary>
        /// Zready1
        /// </summary>
        public string zready1 { get; set; }
        /// <summary>
        /// MultiAreaBusinessMark
        /// </summary>
        public string multiAreaBusinessMark { get; set; }
        /// <summary>
        /// 深圳市创业印章科技有限公司
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 何赞权
        /// </summary>
        public string legalPerson { get; set; }
        /// <summary>
        /// LegalPersonIdno
        /// </summary>
        public string legalPersonIdno { get; set; }
        /// <summary>
        /// 深圳福田区香密新村东区2栋110
        /// </summary>
        public string address { get; set; }
        /// <summary>
        /// 4006811112
        /// </summary>
        public string phone { get; set; }
        /// <summary>
        /// Postcode
        /// </summary>
        public string postcode { get; set; }
        /// <summary>
        /// szftfj
        /// </summary>
        public string approveCode { get; set; }
        /// <summary>
        /// IsEsealCompany
        /// </summary>
        public string isEsealCompany { get; set; }
        /// <summary>
        /// Areacode
        /// </summary>
        public string areacode { get; set; }
        /// <summary>
        /// CreatedAt
        /// </summary>
        public string createdAt { get; set; }
        /// <summary>
        /// UpdatedAt
        /// </summary>
        public string updatedAt { get; set; }
        /// <summary>
        /// DeletedAt
        /// </summary>
        public string deletedAt { get; set; }
        /// <summary>
        /// Y
        /// </summary>
        public string isCyCompany { get; set; }
        /// <summary>
        /// Y
        /// </summary>
        public string isUrgentFactories { get; set; }
        /// <summary>
        /// Factories
        /// </summary>
        public string factories { get; set; }
        /// <summary>
        /// MultiAreaUndertake
        /// </summary>
        public string multiAreaUndertake { get; set; }
        /// <summary>
        /// MultiAreaApply
        /// </summary>
        public string multiAreaApply { get; set; }
        /// <summary>
        /// SpecialIndustryCertificateNum
        /// </summary>
        public string specialIndustryCertificateNum { get; set; }
        /// <summary>
        /// SealSystemInstallState
        /// </summary>
        public string sealSystemInstallState { get; set; }
        /// <summary>
        /// EnterpriseState
        /// </summary>
        public string enterpriseState { get; set; }
        /// <summary>
        /// CertificationDate
        /// </summary>
        public string certificationDate { get; set; }
        /// <summary>
        /// FirstCertificationDate
        /// </summary>
        public string firstCertificationDate { get; set; }
        /// <summary>
        /// CertificationStart
        /// </summary>
        public string certificationStart { get; set; }
        /// <summary>
        /// CertificationEnd
        /// </summary>
        public string certificationEnd { get; set; }
        /// <summary>
        /// PoliceName
        /// </summary>
        public string policeName { get; set; }
        /// <summary>
        /// PolicePhone
        /// </summary>
        public string policePhone { get; set; }
        /// <summary>
        /// PlaceLevel
        /// </summary>
        public string placeLevel { get; set; }
        /// <summary>
        /// LegalPersonPhone
        /// </summary>
        public string legalPersonPhone { get; set; }
        /// <summary>
        /// EnterprisePrincipal
        /// </summary>
        public string enterprisePrincipal { get; set; }
        /// <summary>
        /// EnterprisePrincipalIdno
        /// </summary>
        public string enterprisePrincipalIdno { get; set; }
        /// <summary>
        /// EnterprisePrincipalPhone
        /// </summary>
        public string enterprisePrincipalPhone { get; set; }
        /// <summary>
        /// SignboardName
        /// </summary>
        public string signboardName { get; set; }
        /// <summary>
        /// BusinessLicenseNum
        /// </summary>
        public string businessLicenseNum { get; set; }
        /// <summary>
        /// RegisterDate
        /// </summary>
        public string registerDate { get; set; }
        /// <summary>
        /// Property
        /// </summary>
        public string property { get; set; }
        /// <summary>
        /// RegisterCapital
        /// </summary>
        public string registerCapital { get; set; }
        /// <summary>
        /// LicenseAddress
        /// </summary>
        public string licenseAddress { get; set; }
        /// <summary>
        /// OperatingScope
        /// </summary>
        public string operatingScope { get; set; }
        /// <summary>
        /// OperatingProject
        /// </summary>
        public string operatingProject { get; set; }
        /// <summary>
        /// OperatingFloor
        /// </summary>
        public string operatingFloor { get; set; }
        /// <summary>
        /// OperatingArea
        /// </summary>
        public string operatingArea { get; set; }
        /// <summary>
        /// EnterprisePeopleNum
        /// </summary>
        public string enterprisePeopleNum { get; set; }
        /// <summary>
        /// AreaSource
        /// </summary>
        public string areaSource { get; set; }
        /// <summary>
        /// InsuranceHouse
        /// </summary>
        public string insuranceHouse { get; set; }
        /// <summary>
        /// InsuranceBox
        /// </summary>
        public string insuranceBox { get; set; }
        /// <summary>
        /// FireExtinguisher
        /// </summary>
        public string fireExtinguisher { get; set; }
        /// <summary>
        /// SprayHeader
        /// </summary>
        public string sprayHeader { get; set; }
        /// <summary>
        /// MonitorCamera
        /// </summary>
        public string monitorCamera { get; set; }
        /// <summary>
        /// MonitorSaveTime
        /// </summary>
        public string monitorSaveTime { get; set; }
        /// <summary>
        /// SecurityChief
        /// </summary>
        public string securityChief { get; set; }
        /// <summary>
        /// SecurityChiefPhone
        /// </summary>
        public string securityChiefPhone { get; set; }
        /// <summary>
        /// SecurityPeople
        /// </summary>
        public string securityPeople { get; set; }
        /// <summary>
        /// SecurityCompany
        /// </summary>
        public string securityCompany { get; set; }
    }

    public class getSealCompanyDetailInfo
    {
        /// <summary>
        /// Code
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// success!
        /// </summary>
        public string msg { get; set; }
        /// <summary>
        /// Data
        /// </summary>
        public getSealCompanyDetailData data { get; set; }
    }



    public class getNameByValueData
    {
        /// <summary>
        /// 2017-11-24 18:48:50
        /// </summary>
        public DateTime createTime { get; set; }
        /// <summary>
        /// import
        /// </summary>
        public string createUserId { get; set; }
        /// <summary>
        /// Enable
        /// </summary>
        public bool enable { get; set; }
        /// <summary>
        /// 14d35aaa-3bc8-4acb-beb7-2a8452071ab6
        /// </summary>
        public string id { get; set; }
        /// <summary>
        /// 铜
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Remark
        /// </summary>
        public string remark { get; set; }
        /// <summary>
        /// Sort
        /// </summary>
        public int sort { get; set; }
        /// <summary>
        /// seal_material
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// UpdateTime
        /// </summary>
        public string updateTime { get; set; }
        /// <summary>
        /// UpdateUserId
        /// </summary>
        public string updateUserId { get; set; }
        /// <summary>
        /// 02
        /// </summary>
        public string value { get; set; }
    }

    public class getNameByValueRoot
    {
        /// <summary>
        /// Code
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// Data
        /// </summary>
        public getNameByValueData data { get; set; }
        /// <summary>
        /// success!
        /// </summary>
        public string msg { get; set; }
    }

}
