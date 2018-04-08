//------------------------------------------------------------------------------
// <自动生成>
//     此代码由工具生成。
//     //
//     对此文件的更改可能导致不正确的行为，并在以下条件下丢失:
//     代码重新生成。
// </自动生成>
//------------------------------------------------------------------------------

namespace smssdk
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="smssdk.WebServiceSoap")]
    public interface WebServiceSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMS", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> SendSMSAsync(string sn, string pwd, string mobile, string content);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMS_R", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> SendSMS_RAsync(string sn, string pwd, string mobile, string content, string rrid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMSEx", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> SendSMSExAsync(string sn, string pwd, string mobile, string content, string subcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSMSEx_R", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> SendSMSEx_RAsync(string sn, string pwd, string mobile, string content, string subcode, string rrid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UnRegister", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> UnRegisterAsync(string sn, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ChargUp", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> ChargUpAsync(string sn, string pwd, string cardno, string cardpwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetBalance", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> GetBalanceAsync(string sn, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetStatus", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> GetStatusAsync(string sn, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCode", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> GetCodeAsync(string sn, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UDPPwd", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> UDPPwdAsync(string sn, string pwd, string newpwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UDPSIGN", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> UDPSIGNAsync(string sn, string pwd, string sign);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UDPSIGNEX", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> UDPSIGNEXAsync(string sn, string pwd, string subcode, string sign, string comName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RECSMS", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<smssdk.MOBody[]> RECSMSAsync(string sn, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RECSMSEx", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<smssdk.MOBody[]> RECSMSExAsync(string sn, string pwd, string subcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RECSMS_UTF8", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<smssdk.MOBody[]> RECSMS_UTF8Async(string sn, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/RECSMSEx_UTF8", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<smssdk.MOBody[]> RECSMSEx_UTF8Async(string sn, string pwd, string subcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Register", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> RegisterAsync(string sn, string pwd, string province, string city, string trade, string entname, string linkman, string phone, string mobile, string email, string fax, string address, string postcode, string sign);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetFlag", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> GetFlagAsync(string sn, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SMSTest", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> SMSTestAsync(string sn, string pwd, string mobile);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/TestCode", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> TestCodeAsync(string content, string code, string type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<smssdk.RegistryInfo> GetAllInfoAsync(string sn, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllInfo2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<smssdk.RegistryInfo2> GetAllInfo2Async(string sn, string pwd, string ver, string oem);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SetGaoDuan", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<double> SetGaoDuanAsync(string sn, string pwd, string gd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetGaoDuan", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> GetGaoDuanAsync(string sn, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mt", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> mtAsync(string sn, string pwd, string mobile, string content, string ext, string stime, string rrid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mdSmsSend", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> mdSmsSendAsync(string sn, string pwd, string mobile, string content, string ext, string stime, string rrid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mdSmsSend_u", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> mdSmsSend_uAsync(string sn, string pwd, string mobile, string content, string ext, string stime, string rrid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mdSmsSend_DES", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> mdSmsSend_DESAsync(string sn, string pwd, string mobile, string content, string ext, string stime, string rrid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mdSmsSend_AES", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> mdSmsSend_AESAsync(string sn, string pwd, string mobile, string content, string ext, string stime, string rrid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mdSmsSend_g", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> mdSmsSend_gAsync(string sn, string pwd, string mobile, string content, string ext, string stime, string rrid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> moAsync(string sn, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mo2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> mo2Async(string sn, string pwd, int maxID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/report", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> reportAsync(string sn, string pwd, long maxid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/report2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> report2Async(string sn, string pwd, long maxid, string rrid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/report2DES", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> report2DESAsync(string sn, string pwd, long maxid, string rrid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/msgid", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> msgidAsync(string sn, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/balance", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> balanceAsync(string sn, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/gxmt", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> gxmtAsync(string sn, string pwd, string mobile, string content, string ext, string stime, string rrid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fileMT", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> fileMTAsync(string sn, string pwd, string fname, string rrid, int sort, int total, int ftype, string content);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mmsFileMT", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> mmsFileMTAsync(string sn, string pwd, string rrid, string content);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mdMmsSend", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> mdMmsSendAsync(string sn, string pwd, string title, string mobile, string content, string stime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mdMmsSend_ex", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> mdMmsSend_exAsync(string sn, string pwd, string title, string mobile, string content, string stime, string ext);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mdMmsSend_uex", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> mdMmsSend_uexAsync(string sn, string pwd, string title, string mobile, string content, string stime, string ext);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mdMmsSendF", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> mdMmsSendFAsync(string sn, string pwd, string mobile, string content, string stime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mdAudioSend", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> mdAudioSendAsync(string sn, string pwd, string title, string mobile, string txt, string content, string srcnumber, string stime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mdFaxSend", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> mdFaxSendAsync(string sn, string pwd, string title, string mobile, string content, string srcnumber, string stime);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/mdMmsReceive", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> mdMmsReceiveAsync(string sn, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MongateCsSpSendSmsNew", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> MongateCsSpSendSmsNewAsync(string userId, string password, string pszMobis, string pszMsg, int iMobiCount, string pszSubPort);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MongateCsGetSmsExEx", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string[]> MongateCsGetSmsExExAsync(string userId, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/MongateCsGetStatusReportExEx", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string[]> MongateCsGetStatusReportExExAsync(string userId, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/bianliang", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> bianliangAsync(string sn, string pwd, string mobile, string content, string ext, string stime, string rrid, string bcode);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class MOBody
    {
        
        private string total_numField;
        
        private string this_numField;
        
        private string recvtelField;
        
        private string senderField;
        
        private string contentField;
        
        private string recdateField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string total_num
        {
            get
            {
                return this.total_numField;
            }
            set
            {
                this.total_numField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string this_num
        {
            get
            {
                return this.this_numField;
            }
            set
            {
                this.this_numField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string recvtel
        {
            get
            {
                return this.recvtelField;
            }
            set
            {
                this.recvtelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string sender
        {
            get
            {
                return this.senderField;
            }
            set
            {
                this.senderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string recdate
        {
            get
            {
                return this.recdateField;
            }
            set
            {
                this.recdateField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class RegistryInfo2
    {
        
        private string rESULTField;
        
        private string rEGISTRYCODEField;
        
        private string sERVICECODEField;
        
        private string bALANCEField;
        
        private string cREATEDATEField;
        
        private string rEGISTRYSTATEIDField;
        
        private string pRIORITYField;
        
        private string fIRSTREGISTRYDATEField;
        
        private string rEGISTRYDATEField;
        
        private string aGENTIDField;
        
        private string pRODUCTNAMEField;
        
        private string dESTMOBILEField;
        
        private string fLAGField;
        
        private string rEPLYCONTENTField;
        
        private string iSRETURNField;
        
        private string vERSIONField;
        
        private string gRADEField;
        
        private string pARENTField;
        
        private string sUBSIDIARYField;
        
        private string rOLESField;
        
        private string bALSTATUSField;
        
        private string dISCOUNTField;
        
        private string sLISTField;
        
        private string pOPMField;
        
        private string uPDATEField;
        
        private string mMSField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string RESULT
        {
            get
            {
                return this.rESULTField;
            }
            set
            {
                this.rESULTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string REGISTRYCODE
        {
            get
            {
                return this.rEGISTRYCODEField;
            }
            set
            {
                this.rEGISTRYCODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string SERVICECODE
        {
            get
            {
                return this.sERVICECODEField;
            }
            set
            {
                this.sERVICECODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string BALANCE
        {
            get
            {
                return this.bALANCEField;
            }
            set
            {
                this.bALANCEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string CREATEDATE
        {
            get
            {
                return this.cREATEDATEField;
            }
            set
            {
                this.cREATEDATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string REGISTRYSTATEID
        {
            get
            {
                return this.rEGISTRYSTATEIDField;
            }
            set
            {
                this.rEGISTRYSTATEIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string PRIORITY
        {
            get
            {
                return this.pRIORITYField;
            }
            set
            {
                this.pRIORITYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string FIRSTREGISTRYDATE
        {
            get
            {
                return this.fIRSTREGISTRYDATEField;
            }
            set
            {
                this.fIRSTREGISTRYDATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string REGISTRYDATE
        {
            get
            {
                return this.rEGISTRYDATEField;
            }
            set
            {
                this.rEGISTRYDATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string AGENTID
        {
            get
            {
                return this.aGENTIDField;
            }
            set
            {
                this.aGENTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string PRODUCTNAME
        {
            get
            {
                return this.pRODUCTNAMEField;
            }
            set
            {
                this.pRODUCTNAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string DESTMOBILE
        {
            get
            {
                return this.dESTMOBILEField;
            }
            set
            {
                this.dESTMOBILEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string FLAG
        {
            get
            {
                return this.fLAGField;
            }
            set
            {
                this.fLAGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string REPLYCONTENT
        {
            get
            {
                return this.rEPLYCONTENTField;
            }
            set
            {
                this.rEPLYCONTENTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public string ISRETURN
        {
            get
            {
                return this.iSRETURNField;
            }
            set
            {
                this.iSRETURNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public string VERSION
        {
            get
            {
                return this.vERSIONField;
            }
            set
            {
                this.vERSIONField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public string GRADE
        {
            get
            {
                return this.gRADEField;
            }
            set
            {
                this.gRADEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public string PARENT
        {
            get
            {
                return this.pARENTField;
            }
            set
            {
                this.pARENTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public string SUBSIDIARY
        {
            get
            {
                return this.sUBSIDIARYField;
            }
            set
            {
                this.sUBSIDIARYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
        public string ROLES
        {
            get
            {
                return this.rOLESField;
            }
            set
            {
                this.rOLESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=20)]
        public string BALSTATUS
        {
            get
            {
                return this.bALSTATUSField;
            }
            set
            {
                this.bALSTATUSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=21)]
        public string DISCOUNT
        {
            get
            {
                return this.dISCOUNTField;
            }
            set
            {
                this.dISCOUNTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=22)]
        public string SLIST
        {
            get
            {
                return this.sLISTField;
            }
            set
            {
                this.sLISTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=23)]
        public string POPM
        {
            get
            {
                return this.pOPMField;
            }
            set
            {
                this.pOPMField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=24)]
        public string UPDATE
        {
            get
            {
                return this.uPDATEField;
            }
            set
            {
                this.uPDATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=25)]
        public string MMS
        {
            get
            {
                return this.mMSField;
            }
            set
            {
                this.mMSField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class RegistryInfo
    {
        
        private string rESULTField;
        
        private string rEGISTRYCODEField;
        
        private string sERVICECODEField;
        
        private string bALANCEField;
        
        private string cREATEDATEField;
        
        private string rEGISTRYSTATEIDField;
        
        private string pRIORITYField;
        
        private string fIRSTREGISTRYDATEField;
        
        private string rEGISTRYDATEField;
        
        private string aGENTIDField;
        
        private string pRODUCTNAMEField;
        
        private string dESTMOBILEField;
        
        private string fLAGField;
        
        private string rEPLYCONTENTField;
        
        private string iSRETURNField;
        
        private string vERSIONField;
        
        private string gRADEField;
        
        private string pARENTField;
        
        private string sUBSIDIARYField;
        
        private string rOLESField;
        
        private string bALSTATUSField;
        
        private string dISCOUNTField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string RESULT
        {
            get
            {
                return this.rESULTField;
            }
            set
            {
                this.rESULTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string REGISTRYCODE
        {
            get
            {
                return this.rEGISTRYCODEField;
            }
            set
            {
                this.rEGISTRYCODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string SERVICECODE
        {
            get
            {
                return this.sERVICECODEField;
            }
            set
            {
                this.sERVICECODEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string BALANCE
        {
            get
            {
                return this.bALANCEField;
            }
            set
            {
                this.bALANCEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string CREATEDATE
        {
            get
            {
                return this.cREATEDATEField;
            }
            set
            {
                this.cREATEDATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string REGISTRYSTATEID
        {
            get
            {
                return this.rEGISTRYSTATEIDField;
            }
            set
            {
                this.rEGISTRYSTATEIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string PRIORITY
        {
            get
            {
                return this.pRIORITYField;
            }
            set
            {
                this.pRIORITYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string FIRSTREGISTRYDATE
        {
            get
            {
                return this.fIRSTREGISTRYDATEField;
            }
            set
            {
                this.fIRSTREGISTRYDATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string REGISTRYDATE
        {
            get
            {
                return this.rEGISTRYDATEField;
            }
            set
            {
                this.rEGISTRYDATEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string AGENTID
        {
            get
            {
                return this.aGENTIDField;
            }
            set
            {
                this.aGENTIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string PRODUCTNAME
        {
            get
            {
                return this.pRODUCTNAMEField;
            }
            set
            {
                this.pRODUCTNAMEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string DESTMOBILE
        {
            get
            {
                return this.dESTMOBILEField;
            }
            set
            {
                this.dESTMOBILEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string FLAG
        {
            get
            {
                return this.fLAGField;
            }
            set
            {
                this.fLAGField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string REPLYCONTENT
        {
            get
            {
                return this.rEPLYCONTENTField;
            }
            set
            {
                this.rEPLYCONTENTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public string ISRETURN
        {
            get
            {
                return this.iSRETURNField;
            }
            set
            {
                this.iSRETURNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public string VERSION
        {
            get
            {
                return this.vERSIONField;
            }
            set
            {
                this.vERSIONField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public string GRADE
        {
            get
            {
                return this.gRADEField;
            }
            set
            {
                this.gRADEField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public string PARENT
        {
            get
            {
                return this.pARENTField;
            }
            set
            {
                this.pARENTField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public string SUBSIDIARY
        {
            get
            {
                return this.sUBSIDIARYField;
            }
            set
            {
                this.sUBSIDIARYField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
        public string ROLES
        {
            get
            {
                return this.rOLESField;
            }
            set
            {
                this.rOLESField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=20)]
        public string BALSTATUS
        {
            get
            {
                return this.bALSTATUSField;
            }
            set
            {
                this.bALSTATUSField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=21)]
        public string DISCOUNT
        {
            get
            {
                return this.dISCOUNTField;
            }
            set
            {
                this.dISCOUNTField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface WebServiceSoapChannel : smssdk.WebServiceSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<smssdk.WebServiceSoap>, smssdk.WebServiceSoap
    {
        
    /// <summary>
    /// 实现此分部方法，配置服务终结点。
    /// </summary>
    /// <param name="serviceEndpoint">要配置的终结点</param>
    /// <param name="clientCredentials">客户端凭据</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public WebServiceSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(WebServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), WebServiceSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WebServiceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(WebServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WebServiceSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(WebServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<string> SendSMSAsync(string sn, string pwd, string mobile, string content)
        {
            return base.Channel.SendSMSAsync(sn, pwd, mobile, content);
        }
        
        public System.Threading.Tasks.Task<string> SendSMS_RAsync(string sn, string pwd, string mobile, string content, string rrid)
        {
            return base.Channel.SendSMS_RAsync(sn, pwd, mobile, content, rrid);
        }
        
        public System.Threading.Tasks.Task<string> SendSMSExAsync(string sn, string pwd, string mobile, string content, string subcode)
        {
            return base.Channel.SendSMSExAsync(sn, pwd, mobile, content, subcode);
        }
        
        public System.Threading.Tasks.Task<string> SendSMSEx_RAsync(string sn, string pwd, string mobile, string content, string subcode, string rrid)
        {
            return base.Channel.SendSMSEx_RAsync(sn, pwd, mobile, content, subcode, rrid);
        }
        
        public System.Threading.Tasks.Task<string> UnRegisterAsync(string sn, string pwd)
        {
            return base.Channel.UnRegisterAsync(sn, pwd);
        }
        
        public System.Threading.Tasks.Task<string> ChargUpAsync(string sn, string pwd, string cardno, string cardpwd)
        {
            return base.Channel.ChargUpAsync(sn, pwd, cardno, cardpwd);
        }
        
        public System.Threading.Tasks.Task<string> GetBalanceAsync(string sn, string pwd)
        {
            return base.Channel.GetBalanceAsync(sn, pwd);
        }
        
        public System.Threading.Tasks.Task<string> GetStatusAsync(string sn, string pwd)
        {
            return base.Channel.GetStatusAsync(sn, pwd);
        }
        
        public System.Threading.Tasks.Task<string> GetCodeAsync(string sn, string pwd)
        {
            return base.Channel.GetCodeAsync(sn, pwd);
        }
        
        public System.Threading.Tasks.Task<string> UDPPwdAsync(string sn, string pwd, string newpwd)
        {
            return base.Channel.UDPPwdAsync(sn, pwd, newpwd);
        }
        
        public System.Threading.Tasks.Task<string> UDPSIGNAsync(string sn, string pwd, string sign)
        {
            return base.Channel.UDPSIGNAsync(sn, pwd, sign);
        }
        
        public System.Threading.Tasks.Task<string> UDPSIGNEXAsync(string sn, string pwd, string subcode, string sign, string comName)
        {
            return base.Channel.UDPSIGNEXAsync(sn, pwd, subcode, sign, comName);
        }
        
        public System.Threading.Tasks.Task<smssdk.MOBody[]> RECSMSAsync(string sn, string pwd)
        {
            return base.Channel.RECSMSAsync(sn, pwd);
        }
        
        public System.Threading.Tasks.Task<smssdk.MOBody[]> RECSMSExAsync(string sn, string pwd, string subcode)
        {
            return base.Channel.RECSMSExAsync(sn, pwd, subcode);
        }
        
        public System.Threading.Tasks.Task<smssdk.MOBody[]> RECSMS_UTF8Async(string sn, string pwd)
        {
            return base.Channel.RECSMS_UTF8Async(sn, pwd);
        }
        
        public System.Threading.Tasks.Task<smssdk.MOBody[]> RECSMSEx_UTF8Async(string sn, string pwd, string subcode)
        {
            return base.Channel.RECSMSEx_UTF8Async(sn, pwd, subcode);
        }
        
        public System.Threading.Tasks.Task<string> RegisterAsync(string sn, string pwd, string province, string city, string trade, string entname, string linkman, string phone, string mobile, string email, string fax, string address, string postcode, string sign)
        {
            return base.Channel.RegisterAsync(sn, pwd, province, city, trade, entname, linkman, phone, mobile, email, fax, address, postcode, sign);
        }
        
        public System.Threading.Tasks.Task<string> GetFlagAsync(string sn, string pwd)
        {
            return base.Channel.GetFlagAsync(sn, pwd);
        }
        
        public System.Threading.Tasks.Task<string> SMSTestAsync(string sn, string pwd, string mobile)
        {
            return base.Channel.SMSTestAsync(sn, pwd, mobile);
        }
        
        public System.Threading.Tasks.Task<string> TestCodeAsync(string content, string code, string type)
        {
            return base.Channel.TestCodeAsync(content, code, type);
        }
        
        public System.Threading.Tasks.Task<smssdk.RegistryInfo> GetAllInfoAsync(string sn, string pwd)
        {
            return base.Channel.GetAllInfoAsync(sn, pwd);
        }
        
        public System.Threading.Tasks.Task<smssdk.RegistryInfo2> GetAllInfo2Async(string sn, string pwd, string ver, string oem)
        {
            return base.Channel.GetAllInfo2Async(sn, pwd, ver, oem);
        }
        
        public System.Threading.Tasks.Task<double> SetGaoDuanAsync(string sn, string pwd, string gd)
        {
            return base.Channel.SetGaoDuanAsync(sn, pwd, gd);
        }
        
        public System.Threading.Tasks.Task<string> GetGaoDuanAsync(string sn, string pwd)
        {
            return base.Channel.GetGaoDuanAsync(sn, pwd);
        }
        
        public System.Threading.Tasks.Task<string> mtAsync(string sn, string pwd, string mobile, string content, string ext, string stime, string rrid)
        {
            return base.Channel.mtAsync(sn, pwd, mobile, content, ext, stime, rrid);
        }
        
        public System.Threading.Tasks.Task<string> mdSmsSendAsync(string sn, string pwd, string mobile, string content, string ext, string stime, string rrid)
        {
            return base.Channel.mdSmsSendAsync(sn, pwd, mobile, content, ext, stime, rrid);
        }
        
        public System.Threading.Tasks.Task<string> mdSmsSend_uAsync(string sn, string pwd, string mobile, string content, string ext, string stime, string rrid)
        {
            return base.Channel.mdSmsSend_uAsync(sn, pwd, mobile, content, ext, stime, rrid);
        }
        
        public System.Threading.Tasks.Task<string> mdSmsSend_DESAsync(string sn, string pwd, string mobile, string content, string ext, string stime, string rrid)
        {
            return base.Channel.mdSmsSend_DESAsync(sn, pwd, mobile, content, ext, stime, rrid);
        }
        
        public System.Threading.Tasks.Task<string> mdSmsSend_AESAsync(string sn, string pwd, string mobile, string content, string ext, string stime, string rrid)
        {
            return base.Channel.mdSmsSend_AESAsync(sn, pwd, mobile, content, ext, stime, rrid);
        }
        
        public System.Threading.Tasks.Task<string> mdSmsSend_gAsync(string sn, string pwd, string mobile, string content, string ext, string stime, string rrid)
        {
            return base.Channel.mdSmsSend_gAsync(sn, pwd, mobile, content, ext, stime, rrid);
        }
        
        public System.Threading.Tasks.Task<string> moAsync(string sn, string pwd)
        {
            return base.Channel.moAsync(sn, pwd);
        }
        
        public System.Threading.Tasks.Task<string> mo2Async(string sn, string pwd, int maxID)
        {
            return base.Channel.mo2Async(sn, pwd, maxID);
        }
        
        public System.Threading.Tasks.Task<string> reportAsync(string sn, string pwd, long maxid)
        {
            return base.Channel.reportAsync(sn, pwd, maxid);
        }
        
        public System.Threading.Tasks.Task<string> report2Async(string sn, string pwd, long maxid, string rrid)
        {
            return base.Channel.report2Async(sn, pwd, maxid, rrid);
        }
        
        public System.Threading.Tasks.Task<string> report2DESAsync(string sn, string pwd, long maxid, string rrid)
        {
            return base.Channel.report2DESAsync(sn, pwd, maxid, rrid);
        }
        
        public System.Threading.Tasks.Task<string> msgidAsync(string sn, string pwd)
        {
            return base.Channel.msgidAsync(sn, pwd);
        }
        
        public System.Threading.Tasks.Task<string> balanceAsync(string sn, string pwd)
        {
            return base.Channel.balanceAsync(sn, pwd);
        }
        
        public System.Threading.Tasks.Task<string> gxmtAsync(string sn, string pwd, string mobile, string content, string ext, string stime, string rrid)
        {
            return base.Channel.gxmtAsync(sn, pwd, mobile, content, ext, stime, rrid);
        }
        
        public System.Threading.Tasks.Task<string> fileMTAsync(string sn, string pwd, string fname, string rrid, int sort, int total, int ftype, string content)
        {
            return base.Channel.fileMTAsync(sn, pwd, fname, rrid, sort, total, ftype, content);
        }
        
        public System.Threading.Tasks.Task<string> mmsFileMTAsync(string sn, string pwd, string rrid, string content)
        {
            return base.Channel.mmsFileMTAsync(sn, pwd, rrid, content);
        }
        
        public System.Threading.Tasks.Task<string> mdMmsSendAsync(string sn, string pwd, string title, string mobile, string content, string stime)
        {
            return base.Channel.mdMmsSendAsync(sn, pwd, title, mobile, content, stime);
        }
        
        public System.Threading.Tasks.Task<string> mdMmsSend_exAsync(string sn, string pwd, string title, string mobile, string content, string stime, string ext)
        {
            return base.Channel.mdMmsSend_exAsync(sn, pwd, title, mobile, content, stime, ext);
        }
        
        public System.Threading.Tasks.Task<string> mdMmsSend_uexAsync(string sn, string pwd, string title, string mobile, string content, string stime, string ext)
        {
            return base.Channel.mdMmsSend_uexAsync(sn, pwd, title, mobile, content, stime, ext);
        }
        
        public System.Threading.Tasks.Task<string> mdMmsSendFAsync(string sn, string pwd, string mobile, string content, string stime)
        {
            return base.Channel.mdMmsSendFAsync(sn, pwd, mobile, content, stime);
        }
        
        public System.Threading.Tasks.Task<string> mdAudioSendAsync(string sn, string pwd, string title, string mobile, string txt, string content, string srcnumber, string stime)
        {
            return base.Channel.mdAudioSendAsync(sn, pwd, title, mobile, txt, content, srcnumber, stime);
        }
        
        public System.Threading.Tasks.Task<string> mdFaxSendAsync(string sn, string pwd, string title, string mobile, string content, string srcnumber, string stime)
        {
            return base.Channel.mdFaxSendAsync(sn, pwd, title, mobile, content, srcnumber, stime);
        }
        
        public System.Threading.Tasks.Task<string> mdMmsReceiveAsync(string sn, string pwd)
        {
            return base.Channel.mdMmsReceiveAsync(sn, pwd);
        }
        
        public System.Threading.Tasks.Task<string> MongateCsSpSendSmsNewAsync(string userId, string password, string pszMobis, string pszMsg, int iMobiCount, string pszSubPort)
        {
            return base.Channel.MongateCsSpSendSmsNewAsync(userId, password, pszMobis, pszMsg, iMobiCount, pszSubPort);
        }
        
        public System.Threading.Tasks.Task<string[]> MongateCsGetSmsExExAsync(string userId, string password)
        {
            return base.Channel.MongateCsGetSmsExExAsync(userId, password);
        }
        
        public System.Threading.Tasks.Task<string[]> MongateCsGetStatusReportExExAsync(string userId, string password)
        {
            return base.Channel.MongateCsGetStatusReportExExAsync(userId, password);
        }
        
        public System.Threading.Tasks.Task<string> bianliangAsync(string sn, string pwd, string mobile, string content, string ext, string stime, string rrid, string bcode)
        {
            return base.Channel.bianliangAsync(sn, pwd, mobile, content, ext, stime, rrid, bcode);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WebServiceSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.WebServiceSoap12))
            {
                System.ServiceModel.Channels.CustomBinding result = new System.ServiceModel.Channels.CustomBinding();
                System.ServiceModel.Channels.TextMessageEncodingBindingElement textBindingElement = new System.ServiceModel.Channels.TextMessageEncodingBindingElement();
                textBindingElement.MessageVersion = System.ServiceModel.Channels.MessageVersion.CreateVersion(System.ServiceModel.EnvelopeVersion.Soap12, System.ServiceModel.Channels.AddressingVersion.None);
                result.Elements.Add(textBindingElement);
                System.ServiceModel.Channels.HttpTransportBindingElement httpBindingElement = new System.ServiceModel.Channels.HttpTransportBindingElement();
                httpBindingElement.AllowCookies = true;
                httpBindingElement.MaxBufferSize = int.MaxValue;
                httpBindingElement.MaxReceivedMessageSize = int.MaxValue;
                result.Elements.Add(httpBindingElement);
                return result;
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.WebServiceSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://sdk.entinfo.cn:8060/webservice.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.WebServiceSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://sdk.entinfo.cn:8060/webservice.asmx");
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            WebServiceSoap,
            
            WebServiceSoap12,
        }
    }
}
