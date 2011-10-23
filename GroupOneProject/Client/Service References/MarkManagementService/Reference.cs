﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.MarkManagementService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Member", Namespace="http://schemas.datacontract.org/2004/07/ServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class Member : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FullNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string _ClassField;
        
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
        public string Code {
            get {
                return this.CodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeField, value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FullName {
            get {
                return this.FullNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FullNameField, value) != true)) {
                    this.FullNameField = value;
                    this.RaisePropertyChanged("FullName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string _Class {
            get {
                return this._ClassField;
            }
            set {
                if ((object.ReferenceEquals(this._ClassField, value) != true)) {
                    this._ClassField = value;
                    this.RaisePropertyChanged("_Class");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MarkManagementService.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/IService/GetAuthors", ReplyAction="http://tempuri.org/IService/GetAuthorsResponse")]
        Client.MarkManagementService.Member[] GetAuthors();
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/IService/GetAuthors", ReplyAction="http://tempuri.org/IService/GetAuthorsResponse")]
        System.IAsyncResult BeginGetAuthors(System.AsyncCallback callback, object asyncState);
        
        Client.MarkManagementService.Member[] EndGetAuthors(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/IService/Download", ReplyAction="http://tempuri.org/IService/DownloadResponse")]
        int Download(string path);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/IService/Download", ReplyAction="http://tempuri.org/IService/DownloadResponse")]
        System.IAsyncResult BeginDownload(string path, System.AsyncCallback callback, object asyncState);
        
        int EndDownload(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/IService/GetResource", ReplyAction="http://tempuri.org/IService/GetResourceResponse")]
        byte[] GetResource(string resName);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, ProtectionLevel=System.Net.Security.ProtectionLevel.EncryptAndSign, Action="http://tempuri.org/IService/GetResource", ReplyAction="http://tempuri.org/IService/GetResourceResponse")]
        System.IAsyncResult BeginGetResource(string resName, System.AsyncCallback callback, object asyncState);
        
        byte[] EndGetResource(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Client.MarkManagementService.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetAuthorsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAuthorsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public Client.MarkManagementService.Member[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((Client.MarkManagementService.Member[])(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DownloadCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public DownloadCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public int Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetResourceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetResourceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public byte[] Result {
            get {
                base.RaiseExceptionIfNecessary();
                return (
                    (byte[])(this.results[0])
                    );
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Client.MarkManagementService.IService>, Client.MarkManagementService.IService {
        
        private BeginOperationDelegate onBeginGetAuthorsDelegate;
        
        private EndOperationDelegate onEndGetAuthorsDelegate;
        
        private System.Threading.SendOrPostCallback onGetAuthorsCompletedDelegate;
        
        private BeginOperationDelegate onBeginDownloadDelegate;
        
        private EndOperationDelegate onEndDownloadDelegate;
        
        private System.Threading.SendOrPostCallback onDownloadCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetResourceDelegate;
        
        private EndOperationDelegate onEndGetResourceDelegate;
        
        private System.Threading.SendOrPostCallback onGetResourceCompletedDelegate;
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<GetAuthorsCompletedEventArgs> GetAuthorsCompleted;
        
        public event System.EventHandler<DownloadCompletedEventArgs> DownloadCompleted;
        
        public event System.EventHandler<GetResourceCompletedEventArgs> GetResourceCompleted;
        
        public Client.MarkManagementService.Member[] GetAuthors() {
            return base.Channel.GetAuthors();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetAuthors(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAuthors(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public Client.MarkManagementService.Member[] EndGetAuthors(System.IAsyncResult result) {
            return base.Channel.EndGetAuthors(result);
        }
        
        private System.IAsyncResult OnBeginGetAuthors(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return this.BeginGetAuthors(callback, asyncState);
        }
        
        private object[] OnEndGetAuthors(System.IAsyncResult result) {
            Client.MarkManagementService.Member[] retVal = this.EndGetAuthors(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAuthorsCompleted(object state) {
            if ((this.GetAuthorsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAuthorsCompleted(this, new GetAuthorsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAuthorsAsync() {
            this.GetAuthorsAsync(null);
        }
        
        public void GetAuthorsAsync(object userState) {
            if ((this.onBeginGetAuthorsDelegate == null)) {
                this.onBeginGetAuthorsDelegate = new BeginOperationDelegate(this.OnBeginGetAuthors);
            }
            if ((this.onEndGetAuthorsDelegate == null)) {
                this.onEndGetAuthorsDelegate = new EndOperationDelegate(this.OnEndGetAuthors);
            }
            if ((this.onGetAuthorsCompletedDelegate == null)) {
                this.onGetAuthorsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAuthorsCompleted);
            }
            base.InvokeAsync(this.onBeginGetAuthorsDelegate, null, this.onEndGetAuthorsDelegate, this.onGetAuthorsCompletedDelegate, userState);
        }
        
        public int Download(string path) {
            return base.Channel.Download(path);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginDownload(string path, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDownload(path, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public int EndDownload(System.IAsyncResult result) {
            return base.Channel.EndDownload(result);
        }
        
        private System.IAsyncResult OnBeginDownload(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string path = ((string)(inValues[0]));
            return this.BeginDownload(path, callback, asyncState);
        }
        
        private object[] OnEndDownload(System.IAsyncResult result) {
            int retVal = this.EndDownload(result);
            return new object[] {
                    retVal};
        }
        
        private void OnDownloadCompleted(object state) {
            if ((this.DownloadCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DownloadCompleted(this, new DownloadCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DownloadAsync(string path) {
            this.DownloadAsync(path, null);
        }
        
        public void DownloadAsync(string path, object userState) {
            if ((this.onBeginDownloadDelegate == null)) {
                this.onBeginDownloadDelegate = new BeginOperationDelegate(this.OnBeginDownload);
            }
            if ((this.onEndDownloadDelegate == null)) {
                this.onEndDownloadDelegate = new EndOperationDelegate(this.OnEndDownload);
            }
            if ((this.onDownloadCompletedDelegate == null)) {
                this.onDownloadCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDownloadCompleted);
            }
            base.InvokeAsync(this.onBeginDownloadDelegate, new object[] {
                        path}, this.onEndDownloadDelegate, this.onDownloadCompletedDelegate, userState);
        }
        
        public byte[] GetResource(string resName) {
            return base.Channel.GetResource(resName);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginGetResource(string resName, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetResource(resName, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public byte[] EndGetResource(System.IAsyncResult result) {
            return base.Channel.EndGetResource(result);
        }
        
        private System.IAsyncResult OnBeginGetResource(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string resName = ((string)(inValues[0]));
            return this.BeginGetResource(resName, callback, asyncState);
        }
        
        private object[] OnEndGetResource(System.IAsyncResult result) {
            byte[] retVal = this.EndGetResource(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetResourceCompleted(object state) {
            if ((this.GetResourceCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetResourceCompleted(this, new GetResourceCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetResourceAsync(string resName) {
            this.GetResourceAsync(resName, null);
        }
        
        public void GetResourceAsync(string resName, object userState) {
            if ((this.onBeginGetResourceDelegate == null)) {
                this.onBeginGetResourceDelegate = new BeginOperationDelegate(this.OnBeginGetResource);
            }
            if ((this.onEndGetResourceDelegate == null)) {
                this.onEndGetResourceDelegate = new EndOperationDelegate(this.OnEndGetResource);
            }
            if ((this.onGetResourceCompletedDelegate == null)) {
                this.onGetResourceCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetResourceCompleted);
            }
            base.InvokeAsync(this.onBeginGetResourceDelegate, new object[] {
                        resName}, this.onEndGetResourceDelegate, this.onGetResourceCompletedDelegate, userState);
        }
    }
}
