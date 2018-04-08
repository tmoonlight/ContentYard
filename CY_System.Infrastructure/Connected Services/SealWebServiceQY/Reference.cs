//------------------------------------------------------------------------------
// <自动生成>
//     此代码由工具生成。
//     //
//     对此文件的更改可能导致不正确的行为，并在以下条件下丢失:
//     代码重新生成。
// </自动生成>
//------------------------------------------------------------------------------

namespace SealWebServiceQY
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://183.62.140.54:8008/", ConfigurationName="SealWebServiceQY.SealWebServiceSoap")]
    public interface SealWebServiceSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://183.62.140.54:8008/GetDigitalStamp", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SealWebServiceQY.ArrayOfXElement> GetDigitalStampAsync(string ticket, string str_szkid, string str_kyzm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://183.62.140.54:8008/GetDigitalStamp1", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SealWebServiceQY.ArrayOfXElement> GetDigitalStamp1Async(string ticket, string str_szkid, string str_kyzm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://183.62.140.54:8008/UpdateDepOrTeam", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<int> UpdateDepOrTeamAsync(string ticket, string str_kid, string strDepOrTeam);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://183.62.140.54:8008/IsExDZYZ", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> IsExDZYZAsync(string ticket, string dwmc);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://183.62.140.54:8008/GetSgajy", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> GetSgajyAsync(string ticket, string sid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://183.62.140.54:8008/UpdateYzzbDjg", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<int> UpdateYzzbDjgAsync(string ticket, string sid, string sdjg);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://183.62.140.54:8008/UpdateGAJY", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<int> UpdateGAJYAsync(string ticket, string sid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://183.62.140.54:8008/GetStampInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SealWebServiceQY.ArrayOfXElement> GetStampInfoAsync(string ticket, string kid, string yzm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://183.62.140.54:8008/GetYzzb", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SealWebServiceQY.ArrayOfXElement> GetYzzbAsync(string ticket, string sid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://183.62.140.54:8008/GetYzdw", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SealWebServiceQY.ArrayOfXElement> GetYzdwAsync(string ticket, string udwhz, string uyyzzh, string uzzjgdm, string uswdjh, string ucsi);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://183.62.140.54:8008/GetUCSI", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> GetUCSIAsync(string ticket, string sid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://183.62.140.54:8008/GetEsealKDInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<SealWebServiceQY.ArrayOfXElement> GetEsealKDInfoAsync(string ticket, string key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://183.62.140.54:8008/GetAuthorizationTicket", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Threading.Tasks.Task<string> GetAuthorizationTicketAsync(string userName, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public interface SealWebServiceSoapChannel : SealWebServiceQY.SealWebServiceSoap, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class SealWebServiceSoapClient : System.ServiceModel.ClientBase<SealWebServiceQY.SealWebServiceSoap>, SealWebServiceQY.SealWebServiceSoap
    {
        
    /// <summary>
    /// 实现此分部方法，配置服务终结点。
    /// </summary>
    /// <param name="serviceEndpoint">要配置的终结点</param>
    /// <param name="clientCredentials">客户端凭据</param>
    static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public SealWebServiceSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(SealWebServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), SealWebServiceSoapClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SealWebServiceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(SealWebServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SealWebServiceSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(SealWebServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public SealWebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task<SealWebServiceQY.ArrayOfXElement> GetDigitalStampAsync(string ticket, string str_szkid, string str_kyzm)
        {
            return base.Channel.GetDigitalStampAsync(ticket, str_szkid, str_kyzm);
        }
        
        public System.Threading.Tasks.Task<SealWebServiceQY.ArrayOfXElement> GetDigitalStamp1Async(string ticket, string str_szkid, string str_kyzm)
        {
            return base.Channel.GetDigitalStamp1Async(ticket, str_szkid, str_kyzm);
        }
        
        public System.Threading.Tasks.Task<int> UpdateDepOrTeamAsync(string ticket, string str_kid, string strDepOrTeam)
        {
            return base.Channel.UpdateDepOrTeamAsync(ticket, str_kid, strDepOrTeam);
        }
        
        public System.Threading.Tasks.Task<string> IsExDZYZAsync(string ticket, string dwmc)
        {
            return base.Channel.IsExDZYZAsync(ticket, dwmc);
        }
        
        public System.Threading.Tasks.Task<string> GetSgajyAsync(string ticket, string sid)
        {
            return base.Channel.GetSgajyAsync(ticket, sid);
        }
        
        public System.Threading.Tasks.Task<int> UpdateYzzbDjgAsync(string ticket, string sid, string sdjg)
        {
            return base.Channel.UpdateYzzbDjgAsync(ticket, sid, sdjg);
        }
        
        public System.Threading.Tasks.Task<int> UpdateGAJYAsync(string ticket, string sid)
        {
            return base.Channel.UpdateGAJYAsync(ticket, sid);
        }
        
        public System.Threading.Tasks.Task<SealWebServiceQY.ArrayOfXElement> GetStampInfoAsync(string ticket, string kid, string yzm)
        {
            return base.Channel.GetStampInfoAsync(ticket, kid, yzm);
        }
        
        public System.Threading.Tasks.Task<SealWebServiceQY.ArrayOfXElement> GetYzzbAsync(string ticket, string sid)
        {
            return base.Channel.GetYzzbAsync(ticket, sid);
        }
        
        public System.Threading.Tasks.Task<SealWebServiceQY.ArrayOfXElement> GetYzdwAsync(string ticket, string udwhz, string uyyzzh, string uzzjgdm, string uswdjh, string ucsi)
        {
            return base.Channel.GetYzdwAsync(ticket, udwhz, uyyzzh, uzzjgdm, uswdjh, ucsi);
        }
        
        public System.Threading.Tasks.Task<string> GetUCSIAsync(string ticket, string sid)
        {
            return base.Channel.GetUCSIAsync(ticket, sid);
        }
        
        public System.Threading.Tasks.Task<SealWebServiceQY.ArrayOfXElement> GetEsealKDInfoAsync(string ticket, string key)
        {
            return base.Channel.GetEsealKDInfoAsync(ticket, key);
        }
        
        public System.Threading.Tasks.Task<string> GetAuthorizationTicketAsync(string userName, string password)
        {
            return base.Channel.GetAuthorizationTicketAsync(userName, password);
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
            if ((endpointConfiguration == EndpointConfiguration.SealWebServiceSoap))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.SealWebServiceSoap12))
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
            if ((endpointConfiguration == EndpointConfiguration.SealWebServiceSoap))
            {
                return new System.ServiceModel.EndpointAddress("http://119.135.176.146:9981/erpws/SealWebService.asmx");
            }
            if ((endpointConfiguration == EndpointConfiguration.SealWebServiceSoap12))
            {
                return new System.ServiceModel.EndpointAddress("http://119.135.176.146:9981/erpws/SealWebService.asmx");
            }
            throw new System.InvalidOperationException(string.Format("找不到名称为“{0}”的终结点。", endpointConfiguration));
        }
        
        public enum EndpointConfiguration
        {
            
            SealWebServiceSoap,
            
            SealWebServiceSoap12,
        }
    }
    
    [System.Xml.Serialization.XmlSchemaProviderAttribute(null, IsAny=true)]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("dotnet-svcutil", "1.0.0.0")]
    public partial class ArrayOfXElement : object, System.Xml.Serialization.IXmlSerializable
    {
        
        private System.Collections.Generic.List<System.Xml.Linq.XElement> nodesList = new System.Collections.Generic.List<System.Xml.Linq.XElement>();
        
        public ArrayOfXElement()
        {
        }
        
        public virtual System.Collections.Generic.List<System.Xml.Linq.XElement> Nodes
        {
            get
            {
                return this.nodesList;
            }
        }
        
        public virtual System.Xml.Schema.XmlSchema GetSchema()
        {
            throw new System.NotImplementedException();
        }
        
        public virtual void WriteXml(System.Xml.XmlWriter writer)
        {
            System.Collections.Generic.IEnumerator<System.Xml.Linq.XElement> e = nodesList.GetEnumerator();
            for (
            ; e.MoveNext(); 
            )
            {
                ((System.Xml.Serialization.IXmlSerializable)(e.Current)).WriteXml(writer);
            }
        }
        
        public virtual void ReadXml(System.Xml.XmlReader reader)
        {
            for (
            ; (reader.NodeType != System.Xml.XmlNodeType.EndElement); 
            )
            {
                if ((reader.NodeType == System.Xml.XmlNodeType.Element))
                {
                    System.Xml.Linq.XElement elem = new System.Xml.Linq.XElement("default");
                    ((System.Xml.Serialization.IXmlSerializable)(elem)).ReadXml(reader);
                    Nodes.Add(elem);
                }
                else
                {
                    reader.Skip();
                }
            }
        }
    }
}
