// =====COPYRIGHT=====
// github ssh copyright text123
// =====COPYRIGHT=====
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServices.Copyright.WebApplication.SessionTokenClient {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SessionTokenV1", Namespace="http://schemas.datacontract.org/2004/07/Srs.WebPlatform.WebServices.SrsWPSite")]
    [System.SerializableAttribute()]
    public partial class SessionTokenV1 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorizedSessionTokenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTimeOffset SessionToken_CreatedAtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTimeOffset SessionToken_ExpirationAtField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SessionToken_PortalUserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid SessionToken_SessionTokenGUIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SessionToken_SessionTokenIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string AuthorizedSessionToken {
            get {
                return this.AuthorizedSessionTokenField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorizedSessionTokenField, value) != true)) {
                    this.AuthorizedSessionTokenField = value;
                    this.RaisePropertyChanged("AuthorizedSessionToken");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTimeOffset SessionToken_CreatedAt {
            get {
                return this.SessionToken_CreatedAtField;
            }
            set {
                if ((this.SessionToken_CreatedAtField.Equals(value) != true)) {
                    this.SessionToken_CreatedAtField = value;
                    this.RaisePropertyChanged("SessionToken_CreatedAt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTimeOffset SessionToken_ExpirationAt {
            get {
                return this.SessionToken_ExpirationAtField;
            }
            set {
                if ((this.SessionToken_ExpirationAtField.Equals(value) != true)) {
                    this.SessionToken_ExpirationAtField = value;
                    this.RaisePropertyChanged("SessionToken_ExpirationAt");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SessionToken_PortalUserId {
            get {
                return this.SessionToken_PortalUserIdField;
            }
            set {
                if ((this.SessionToken_PortalUserIdField.Equals(value) != true)) {
                    this.SessionToken_PortalUserIdField = value;
                    this.RaisePropertyChanged("SessionToken_PortalUserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid SessionToken_SessionTokenGUId {
            get {
                return this.SessionToken_SessionTokenGUIdField;
            }
            set {
                if ((this.SessionToken_SessionTokenGUIdField.Equals(value) != true)) {
                    this.SessionToken_SessionTokenGUIdField = value;
                    this.RaisePropertyChanged("SessionToken_SessionTokenGUId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SessionToken_SessionTokenId {
            get {
                return this.SessionToken_SessionTokenIdField;
            }
            set {
                if ((this.SessionToken_SessionTokenIdField.Equals(value) != true)) {
                    this.SessionToken_SessionTokenIdField = value;
                    this.RaisePropertyChanged("SessionToken_SessionTokenId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SessionTokenClient.ISessionTokenServiceV2")]
    public interface ISessionTokenServiceV2 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISessionTokenServiceV2/ValidateSessionToken", ReplyAction="http://tempuri.org/ISessionTokenServiceV2/ValidateSessionTokenResponse")]
        Srs.WebPlatform.Common.WebServiceObjectResponseV1<Srs.WebPlatform.Common.AuthorizationV1> ValidateSessionToken(string sessionTokenId, string methodGuid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISessionTokenServiceV2/GetSessionTokenById", ReplyAction="http://tempuri.org/ISessionTokenServiceV2/GetSessionTokenByIdResponse")]
        Srs.WebPlatform.Common.WebServiceObjectResponseV1<WebServices.Copyright.WebApplication.SessionTokenClient.SessionTokenV1> GetSessionTokenById(string sessionTokenId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISessionTokenServiceV2/CreateSessionToken", ReplyAction="http://tempuri.org/ISessionTokenServiceV2/CreateSessionTokenResponse")]
        Srs.WebPlatform.Common.WebServiceObjectResponseV1<WebServices.Copyright.WebApplication.SessionTokenClient.SessionTokenV1> CreateSessionToken(string userName, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISessionTokenServiceV2/CreateSessionTokenForPortalUser", ReplyAction="http://tempuri.org/ISessionTokenServiceV2/CreateSessionTokenForPortalUserResponse" +
            "")]
        Srs.WebPlatform.Common.WebServiceObjectResponseV1<WebServices.Copyright.WebApplication.SessionTokenClient.SessionTokenV1> CreateSessionTokenForPortalUser(string userName, string password, string portalUserGuid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISessionTokenServiceV2/CreateSessionTokenForDevice", ReplyAction="http://tempuri.org/ISessionTokenServiceV2/CreateSessionTokenForDeviceResponse")]
        Srs.WebPlatform.Common.WebServiceObjectResponseV1<WebServices.Copyright.WebApplication.SessionTokenClient.SessionTokenV1> CreateSessionTokenForDevice(int deviceTypeId, string fingerprint, string portalUrl);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISessionTokenServiceV2/GetSessionTokenByPortalUserId", ReplyAction="http://tempuri.org/ISessionTokenServiceV2/GetSessionTokenByPortalUserIdResponse")]
        Srs.WebPlatform.Common.WebServiceCollectionResponseV1<WebServices.Copyright.WebApplication.SessionTokenClient.SessionTokenV1> GetSessionTokenByPortalUserId(string sessionTokenId, int portalUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISessionTokenServiceV2/GetSessionTokenByCriteria", ReplyAction="http://tempuri.org/ISessionTokenServiceV2/GetSessionTokenByCriteriaResponse")]
        Srs.WebPlatform.Common.WebServiceCollectionResponseV1<WebServices.Copyright.WebApplication.SessionTokenClient.SessionTokenV1> GetSessionTokenByCriteria(string sessionTokenId, string sessionTokenGuid, string userName, string passportCrmGuid, string passportGuid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISessionTokenServiceV2/ExpireSessionToken", ReplyAction="http://tempuri.org/ISessionTokenServiceV2/ExpireSessionTokenResponse")]
        Srs.WebPlatform.Common.WebServiceObjectResponseV1<WebServices.Copyright.WebApplication.SessionTokenClient.SessionTokenV1> ExpireSessionToken(string sessionTokenId, int targetSessionTokenId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISessionTokenServiceV2Channel : WebServices.Copyright.WebApplication.SessionTokenClient.ISessionTokenServiceV2, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SessionTokenServiceV2Client : System.ServiceModel.ClientBase<WebServices.Copyright.WebApplication.SessionTokenClient.ISessionTokenServiceV2>, WebServices.Copyright.WebApplication.SessionTokenClient.ISessionTokenServiceV2 {
        
        public SessionTokenServiceV2Client() {
        }
        
        public SessionTokenServiceV2Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SessionTokenServiceV2Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SessionTokenServiceV2Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SessionTokenServiceV2Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Srs.WebPlatform.Common.WebServiceObjectResponseV1<Srs.WebPlatform.Common.AuthorizationV1> ValidateSessionToken(string sessionTokenId, string methodGuid) {
            return base.Channel.ValidateSessionToken(sessionTokenId, methodGuid);
        }
        
        public Srs.WebPlatform.Common.WebServiceObjectResponseV1<WebServices.Copyright.WebApplication.SessionTokenClient.SessionTokenV1> GetSessionTokenById(string sessionTokenId) {
            return base.Channel.GetSessionTokenById(sessionTokenId);
        }
        
        public Srs.WebPlatform.Common.WebServiceObjectResponseV1<WebServices.Copyright.WebApplication.SessionTokenClient.SessionTokenV1> CreateSessionToken(string userName, string password) {
            return base.Channel.CreateSessionToken(userName, password);
        }
        
        public Srs.WebPlatform.Common.WebServiceObjectResponseV1<WebServices.Copyright.WebApplication.SessionTokenClient.SessionTokenV1> CreateSessionTokenForPortalUser(string userName, string password, string portalUserGuid) {
            return base.Channel.CreateSessionTokenForPortalUser(userName, password, portalUserGuid);
        }
        
        public Srs.WebPlatform.Common.WebServiceObjectResponseV1<WebServices.Copyright.WebApplication.SessionTokenClient.SessionTokenV1> CreateSessionTokenForDevice(int deviceTypeId, string fingerprint, string portalUrl) {
            return base.Channel.CreateSessionTokenForDevice(deviceTypeId, fingerprint, portalUrl);
        }
        
        public Srs.WebPlatform.Common.WebServiceCollectionResponseV1<WebServices.Copyright.WebApplication.SessionTokenClient.SessionTokenV1> GetSessionTokenByPortalUserId(string sessionTokenId, int portalUserId) {
            return base.Channel.GetSessionTokenByPortalUserId(sessionTokenId, portalUserId);
        }
        
        public Srs.WebPlatform.Common.WebServiceCollectionResponseV1<WebServices.Copyright.WebApplication.SessionTokenClient.SessionTokenV1> GetSessionTokenByCriteria(string sessionTokenId, string sessionTokenGuid, string userName, string passportCrmGuid, string passportGuid) {
            return base.Channel.GetSessionTokenByCriteria(sessionTokenId, sessionTokenGuid, userName, passportCrmGuid, passportGuid);
        }
        
        public Srs.WebPlatform.Common.WebServiceObjectResponseV1<WebServices.Copyright.WebApplication.SessionTokenClient.SessionTokenV1> ExpireSessionToken(string sessionTokenId, int targetSessionTokenId) {
            return base.Channel.ExpireSessionToken(sessionTokenId, targetSessionTokenId);
        }
    }
}
