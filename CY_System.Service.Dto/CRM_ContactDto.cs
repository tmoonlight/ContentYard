using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace CY_System.Service.Dto
{
    /// <summary>
	/// CRM_Contact数据传输实体类
    /// 作者: C
    /// 时间: 2018-01-18 16:35:35
    /// </summary>
    public class CRM_ContactDto
    {
        /// <summary>
        /// OID属性
        /// <summary>
        public string OID { get; set; }

        /// <summary>
        /// cContactCode属性
        /// <summary>
        public string cContactCode { get; set; }

        /// <summary>
        /// cCusCode属性
        /// <summary>
        public string cCusCode { get; set; }

        /// <summary>
        /// cContactName属性
        /// <summary>
        public string cContactName { get; set; }

        /// <summary>
        /// cAppellation属性
        /// <summary>
        public string cAppellation { get; set; }

        /// <summary>
        /// bcSexID属性
        /// <summary>
        public int? bcSexID { get; set; }

        /// <summary>
        /// dBirthday属性
        /// <summary>
        public DateTime? dBirthday { get; set; }

        /// <summary>
        /// cNative属性
        /// <summary>
        public string cNative { get; set; }

        /// <summary>
        /// bcDutyID属性
        /// <summary>
        public string bcDutyID { get; set; }

        /// <summary>
        /// cSuperiorID属性
        /// <summary>
        public string cSuperiorID { get; set; }

        /// <summary>
        /// cMobilePhone属性
        /// <summary>
        public string cMobilePhone { get; set; }

        /// <summary>
        /// cOfficePhone属性
        /// <summary>
        public string cOfficePhone { get; set; }

        /// <summary>
        /// cHomePhone属性
        /// <summary>
        public string cHomePhone { get; set; }

        /// <summary>
        /// cCall属性
        /// <summary>
        public string cCall { get; set; }

        /// <summary>
        /// cEmail属性
        /// <summary>
        public string cEmail { get; set; }

        /// <summary>
        /// cHomePage属性
        /// <summary>
        public string cHomePage { get; set; }

        /// <summary>
        /// cWorkAddress属性
        /// <summary>
        public string cWorkAddress { get; set; }

        /// <summary>
        /// cZipcode属性
        /// <summary>
        public string cZipcode { get; set; }

        /// <summary>
        /// bcMarriageID属性
        /// <summary>
        public int? bcMarriageID { get; set; }

        /// <summary>
        /// cHomeMember属性
        /// <summary>
        public string cHomeMember { get; set; }

        /// <summary>
        /// cHomeAddress属性
        /// <summary>
        public string cHomeAddress { get; set; }

        /// <summary>
        /// bcTasteID属性
        /// <summary>
        public string bcTasteID { get; set; }

        /// <summary>
        /// bMajor属性
        /// <summary>
        public bool? bMajor { get; set; }

        /// <summary>
        /// cMemo属性
        /// <summary>
        public string cMemo { get; set; }

        /// <summary>
        /// cPrincipal属性
        /// <summary>
        public string cPrincipal { get; set; }

        /// <summary>
        /// cCreator属性
        /// <summary>
        public string cCreator { get; set; }

        /// <summary>
        /// cRevisor属性
        /// <summary>
        public string cRevisor { get; set; }

        /// <summary>
        /// dModifyDate属性
        /// <summary>
        public DateTime? dModifyDate { get; set; }

        /// <summary>
        /// dCreateDate属性
        /// <summary>
        public DateTime? dCreateDate { get; set; }

        /// <summary>
        /// cConDefine1属性
        /// <summary>
        public string cConDefine1 { get; set; }

        /// <summary>
        /// cConDefine2属性
        /// <summary>
        public string cConDefine2 { get; set; }

        /// <summary>
        /// cConDefine3属性
        /// <summary>
        public string cConDefine3 { get; set; }

        /// <summary>
        /// cConDefine4属性
        /// <summary>
        public string cConDefine4 { get; set; }

        /// <summary>
        /// cConDefine5属性
        /// <summary>
        public string cConDefine5 { get; set; }

        /// <summary>
        /// cConDefine6属性
        /// <summary>
        public string cConDefine6 { get; set; }

        /// <summary>
        /// cConDefine7属性
        /// <summary>
        public string cConDefine7 { get; set; }

        /// <summary>
        /// cConDefine8属性
        /// <summary>
        public string cConDefine8 { get; set; }

        /// <summary>
        /// cConDefine9属性
        /// <summary>
        public string cConDefine9 { get; set; }

        /// <summary>
        /// cConDefine10属性
        /// <summary>
        public string cConDefine10 { get; set; }

        /// <summary>
        /// cConDefine11属性
        /// <summary>
        public int? cConDefine11 { get; set; }

        /// <summary>
        /// cConDefine12属性
        /// <summary>
        public int? cConDefine12 { get; set; }

        /// <summary>
        /// cConDefine13属性
        /// <summary>
        public double? cConDefine13 { get; set; }

        /// <summary>
        /// cConDefine14属性
        /// <summary>
        public double? cConDefine14 { get; set; }

        /// <summary>
        /// cConDefine15属性
        /// <summary>
        public DateTime? cConDefine15 { get; set; }

        /// <summary>
        /// cConDefine16属性
        /// <summary>
        public DateTime? cConDefine16 { get; set; }

        /// <summary>
        /// ufts属性
        /// <summary>
        public string ufts { get; set; }

        /// <summary>
        /// src_type属性
        /// <summary>
        public int? src_type { get; set; }

        /// <summary>
        /// src_id属性
        /// <summary>
        public string src_id { get; set; }

        /// <summary>
        /// cConDepart属性
        /// <summary>
        public string cConDepart { get; set; }

        /// <summary>
        /// fApprovedExpense属性
        /// <summary>
        public double? fApprovedExpense { get; set; }

        /// <summary>
        /// fExpense属性
        /// <summary>
        public double? fExpense { get; set; }

        /// <summary>
        /// fFax属性
        /// <summary>
        public string fFax { get; set; }

        /// <summary>
        /// fDoNotCall属性
        /// <summary>
        public int? fDoNotCall { get; set; }

        /// <summary>
        /// fFaxOptOut属性
        /// <summary>
        public int? fFaxOptOut { get; set; }

        /// <summary>
        /// fEmailOptOut属性
        /// <summary>
        public int? fEmailOptOut { get; set; }

        /// <summary>
        /// fAssistantName属性
        /// <summary>
        public string fAssistantName { get; set; }

        /// <summary>
        /// fAssistantPhone属性
        /// <summary>
        public string fAssistantPhone { get; set; }

        /// <summary>
        /// fLeadSource属性
        /// <summary>
        public int? fLeadSource { get; set; }

        /// <summary>
        /// dConEDate属性
        /// <summary>
        public DateTime? dConEDate { get; set; }

        /// <summary>
        /// cWechat属性
        /// <summary>
        public string cWechat { get; set; }

        /// <summary>
        /// PictureGUID属性
        /// <summary>
        public Guid? PictureGUID { get; set; }


    }
}


