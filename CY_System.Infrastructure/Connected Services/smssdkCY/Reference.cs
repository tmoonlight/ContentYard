//------------------------------------------------------------------------------
// <自动生成>
//     此代码由工具生成。
//     //
//     对此文件的更改可能导致不正确的行为，并在以下条件下丢失:
//     代码重新生成。
// </自动生成>
//------------------------------------------------------------------------------

namespace smssdkCY
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://ws.flaginfo.com.cn", ConfigurationName="smssdkCY.SmsPortType")]
    public interface SmsPortType
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<smssdkCY.SmsResponse> SmsAsync(smssdkCY.SmsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<smssdkCY.ReportResponse> ReportAsync(smssdkCY.ReportRequest request);
        
        // CODEGEN: 正在生成消息协定，因为操作具有多个返回值。
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<smssdkCY.ReplyResponse> ReplyAsync(smssdkCY.ReplyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<smssdkCY.ReplyConfirmResponse> ReplyConfirmAsync(smssdkCY.ReplyConfirmRequest request);
        
        // CODEGEN: 正在生成消息协定，因为操作具有多个返回值。
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<smssdkCY.SearchSmsNumResponse> SearchSmsNumAsync(smssdkCY.SearchSmsNumRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<smssdkCY.AuditingResponse> AuditingAsync(smssdkCY.AuditingRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Sms", WrapperNamespace="http://ws.flaginfo.com.cn", IsWrapped=true)]
    public partial class SmsRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in2;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in3;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in4;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=5)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in5;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=6)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in6;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=7)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in7;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=8)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in8;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=9)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in9;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=10)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in10;
        
        public SmsRequest()
        {
        }
        
        public SmsRequest(string in0, string in1, string in2, string in3, string in4, string in5, string in6, string in7, string in8, string in9, string in10)
        {
            this.in0 = in0;
            this.in1 = in1;
            this.in2 = in2;
            this.in3 = in3;
            this.in4 = in4;
            this.in5 = in5;
            this.in6 = in6;
            this.in7 = in7;
            this.in8 = in8;
            this.in9 = in9;
            this.in10 = in10;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SmsResponse", WrapperNamespace="http://ws.flaginfo.com.cn", IsWrapped=true)]
    public partial class SmsResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string @out;
        
        public SmsResponse()
        {
        }
        
        public SmsResponse(string @out)
        {
            this.@out = @out;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="Report", WrapperNamespace="http://ws.flaginfo.com.cn", IsWrapped=true)]
    public partial class ReportRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in2;
        
        public ReportRequest()
        {
        }
        
        public ReportRequest(string in0, string in1, string in2)
        {
            this.in0 = in0;
            this.in1 = in1;
            this.in2 = in2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReportResponse", WrapperNamespace="http://ws.flaginfo.com.cn", IsWrapped=true)]
    public partial class ReportResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string @out;
        
        public ReportResponse()
        {
        }
        
        public ReportResponse(string @out)
        {
            this.@out = @out;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://ws.flaginfo.com.cn")]
    public partial class Reply
    {
        
        private string callMdnField;
        
        private string mdnField;
        
        private string contentField;
        
        private string reply_timeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string callMdn
        {
            get
            {
                return this.callMdnField;
            }
            set
            {
                this.callMdnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string mdn
        {
            get
            {
                return this.mdnField;
            }
            set
            {
                this.mdnField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public string reply_time
        {
            get
            {
                return this.reply_timeField;
            }
            set
            {
                this.reply_timeField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReplyRequest", WrapperNamespace="http://ws.flaginfo.com.cn", IsWrapped=true)]
    public partial class ReplyRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in2;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in3;
        
        public ReplyRequest()
        {
        }
        
        public ReplyRequest(string in0, string in1, string in2, string in3)
        {
            this.in0 = in0;
            this.in1 = in1;
            this.in2 = in2;
            this.in3 = in3;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReplyResponse", WrapperNamespace="http://ws.flaginfo.com.cn", IsWrapped=true)]
    public partial class ReplyResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string result;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string confirm_time;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string id;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute("replys", IsNullable=true)]
        public smssdkCY.Reply[] replys;
        
        public ReplyResponse()
        {
        }
        
        public ReplyResponse(string result, string confirm_time, string id, smssdkCY.Reply[] replys)
        {
            this.result = result;
            this.confirm_time = confirm_time;
            this.id = id;
            this.replys = replys;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReplyConfirmRequest", WrapperNamespace="http://ws.flaginfo.com.cn", IsWrapped=true)]
    public partial class ReplyConfirmRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in2;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in3;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=4)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in4;
        
        public ReplyConfirmRequest()
        {
        }
        
        public ReplyConfirmRequest(string in0, string in1, string in2, string in3, string in4)
        {
            this.in0 = in0;
            this.in1 = in1;
            this.in2 = in2;
            this.in3 = in3;
            this.in4 = in4;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ReplyConfirmResponse", WrapperNamespace="http://ws.flaginfo.com.cn", IsWrapped=true)]
    public partial class ReplyConfirmResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string result;
        
        public ReplyConfirmResponse()
        {
        }
        
        public ReplyConfirmResponse(string result)
        {
            this.result = result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SearchSmsNumRequest", WrapperNamespace="http://ws.flaginfo.com.cn", IsWrapped=true)]
    public partial class SearchSmsNumRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in2;
        
        public SearchSmsNumRequest()
        {
        }
        
        public SearchSmsNumRequest(string in0, string in1, string in2)
        {
            this.in0 = in0;
            this.in1 = in1;
            this.in2 = in2;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SearchSmsNumResponse", WrapperNamespace="http://ws.flaginfo.com.cn", IsWrapped=true)]
    public partial class SearchSmsNumResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string result;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string number;
        
        public SearchSmsNumResponse()
        {
        }
        
        public SearchSmsNumResponse(string result, string number)
        {
            this.result = result;
            this.number = number;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AuditingRequest", WrapperNamespace="http://ws.flaginfo.com.cn", IsWrapped=true)]
    public partial class AuditingRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in0;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in1;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in2;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=3)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string in3;
        
        public AuditingRequest()
        {
        }
        
        public AuditingRequest(string in0, string in1, string in2, string in3)
        {
            this.in0 = in0;
            this.in1 = in1;
            this.in2 = in2;
            this.in3 = in3;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AuditingResponse", WrapperNamespace="http://ws.flaginfo.com.cn", IsWrapped=true)]
    public partial class AuditingResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://ws.flaginfo.com.cn", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string @out;
        
        public AuditingResponse()
        {
        }
        
        public AuditingResponse(string @out)
        {
            this.@out = @out;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface SmsPortTypeChannel : smssdkCY.SmsPortType, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class SmsPortTypeClient : System.ServiceModel.ClientBase<smssdkCY.SmsPortType>, smssdkCY.SmsPortType
    {
        
    /// <summary>
    /// 实现此分部方法，配置服务终结点。
    /// </summary>
    /// <param name="serviceEndpoint">要配置的终结点</param>
    /// <param name="clientCredentials">客户端凭据</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SmsPortTypeClient() : 
                base(SmsPortTypeClient.GetDefaultBinding(), SmsPortTypeClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.SmsHttpPort.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SmsPortTypeClient(EndpointConfiguration endpointConfiguration) : 
                base(SmsPortTypeClient.GetBindingForEndpoint(endpointConfiguration), SmsPortTypeClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SmsPortTypeClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SmsPortTypeClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SmsPortTypeClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SmsPortTypeClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SmsPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<smssdkCY.SmsResponse> smssdkCY.SmsPortType.SmsAsync(smssdkCY.SmsRequest request)
        {
            return base.Channel.SmsAsync(request);
        }
        
        public System.Threading.Tasks.Task<smssdkCY.SmsResponse> SmsAsync(string in0, string in1, string in2, string in3, string in4, string in5, string in6, string in7, string in8, string in9, string in10)
        {
            smssdkCY.SmsRequest inValue = new smssdkCY.SmsRequest();
            inValue.in0 = in0;
            inValue.in1 = in1;
            inValue.in2 = in2;
            inValue.in3 = in3;
            inValue.in4 = in4;
            inValue.in5 = in5;
            inValue.in6 = in6;
            inValue.in7 = in7;
            inValue.in8 = in8;
            inValue.in9 = in9;
            inValue.in10 = in10;
            return ((smssdkCY.SmsPortType)(this)).SmsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<smssdkCY.ReportResponse> smssdkCY.SmsPortType.ReportAsync(smssdkCY.ReportRequest request)
        {
            return base.Channel.ReportAsync(request);
        }
        
        public System.Threading.Tasks.Task<smssdkCY.ReportResponse> ReportAsync(string in0, string in1, string in2)
        {
            smssdkCY.ReportRequest inValue = new smssdkCY.ReportRequest();
            inValue.in0 = in0;
            inValue.in1 = in1;
            inValue.in2 = in2;
            return ((smssdkCY.SmsPortType)(this)).ReportAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<smssdkCY.ReplyResponse> ReplyAsync(smssdkCY.ReplyRequest request)
        {
            return base.Channel.ReplyAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<smssdkCY.ReplyConfirmResponse> smssdkCY.SmsPortType.ReplyConfirmAsync(smssdkCY.ReplyConfirmRequest request)
        {
            return base.Channel.ReplyConfirmAsync(request);
        }
        
        public System.Threading.Tasks.Task<smssdkCY.ReplyConfirmResponse> ReplyConfirmAsync(string in0, string in1, string in2, string in3, string in4)
        {
            smssdkCY.ReplyConfirmRequest inValue = new smssdkCY.ReplyConfirmRequest();
            inValue.in0 = in0;
            inValue.in1 = in1;
            inValue.in2 = in2;
            inValue.in3 = in3;
            inValue.in4 = in4;
            return ((smssdkCY.SmsPortType)(this)).ReplyConfirmAsync(inValue);
        }
        
        public System.Threading.Tasks.Task<smssdkCY.SearchSmsNumResponse> SearchSmsNumAsync(smssdkCY.SearchSmsNumRequest request)
        {
            return base.Channel.SearchSmsNumAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<smssdkCY.AuditingResponse> smssdkCY.SmsPortType.AuditingAsync(smssdkCY.AuditingRequest request)
        {
            return base.Channel.AuditingAsync(request);
        }
        
        public System.Threading.Tasks.Task<smssdkCY.AuditingResponse> AuditingAsync(string in0, string in1, string in2, string in3)
        {
            smssdkCY.AuditingRequest inValue = new smssdkCY.AuditingRequest();
            inValue.in0 = in0;
            inValue.in1 = in1;
            inValue.in2 = in2;
            inValue.in3 = in3;
            return ((smssdkCY.SmsPortType)(this)).AuditingAsync(inValue);
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
            if ((endpointConfiguration == EndpointConfiguration.SmsHttpPort))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.SmsHttpPort))
            {
                return new System.ServiceModel.EndpointAddress("http://api.ums86.com:8899/sms_hb/services/Sms/");
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return SmsPortTypeClient.GetBindingForEndpoint(EndpointConfiguration.SmsHttpPort);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return SmsPortTypeClient.GetEndpointAddress(EndpointConfiguration.SmsHttpPort);
        }
        
        public enum EndpointConfiguration
        {
            
            SmsHttpPort,
        }
    }
}
