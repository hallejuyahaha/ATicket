//------------------------------------------------------------------------------
// <自动生成>
//     此代码由工具生成。
//     //
//     对此文件的更改可能导致不正确的行为，并在以下条件下丢失:
//     代码重新生成。
// </自动生成>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name = "BasicHttpBinding_IService1", Namespace = "http://tempuri.org/")]
    public partial class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol
    {

        private System.Threading.SendOrPostCallback GetDataOperationCompleted;

        private System.Threading.SendOrPostCallback GetDataUsingDataContractOperationCompleted;

        private System.Threading.SendOrPostCallback GetShowOperationCompleted;

        private System.Threading.SendOrPostCallback LoginOperationCompleted;

        private System.Threading.SendOrPostCallback RegisterOperationCompleted;

        private System.Threading.SendOrPostCallback GetMonitorsOperationCompleted;

        private System.Threading.SendOrPostCallback AddMonitorsOperationCompleted;

        private System.Threading.SendOrPostCallback DeleteMonitorsOperationCompleted;

        private bool useDefaultCredentialsSetExplicitly;

        /// <remarks/>
        public Service1()
        {
            this.Url = "http://192.168.1.2:8000/Service1.svc";
            if ((this.IsLocalFileSystemWebService(this.Url) == true))
            {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else
            {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        public new string Url
        {
            get
            {
                return base.Url;
            }
            set
            {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true)
                            && (this.useDefaultCredentialsSetExplicitly == false))
                            && (this.IsLocalFileSystemWebService(value) == false)))
                {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }

        public new bool UseDefaultCredentials
        {
            get
            {
                return base.UseDefaultCredentials;
            }
            set
            {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        /// <remarks/>
        public event GetDataCompletedEventHandler GetDataCompleted;

        /// <remarks/>
        public event GetDataUsingDataContractCompletedEventHandler GetDataUsingDataContractCompleted;

        /// <remarks/>
        public event GetShowCompletedEventHandler GetShowCompleted;

        /// <remarks/>
        public event LoginCompletedEventHandler LoginCompleted;

        /// <remarks/>
        public event RegisterCompletedEventHandler RegisterCompleted;

        /// <remarks/>
        public event GetMonitorsCompletedEventHandler GetMonitorsCompleted;

        /// <remarks/>
        public event AddMonitorsCompletedEventHandler AddMonitorsCompleted;

        /// <remarks/>
        public event DeleteMonitorsCompletedEventHandler DeleteMonitorsCompleted;

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/GetData", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string GetData(int value, [System.Xml.Serialization.XmlIgnoreAttribute()] bool valueSpecified)
        {
            object[] results = this.Invoke("GetData", new object[] {
                        value,
                        valueSpecified});
            return ((string)(results[0]));
        }

        /// <remarks/>
        public void GetDataAsync(int value, bool valueSpecified)
        {
            this.GetDataAsync(value, valueSpecified, null);
        }

        /// <remarks/>
        public void GetDataAsync(int value, bool valueSpecified, object userState)
        {
            if ((this.GetDataOperationCompleted == null))
            {
                this.GetDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDataOperationCompleted);
            }
            this.InvokeAsync("GetData", new object[] {
                        value,
                        valueSpecified}, this.GetDataOperationCompleted, userState);
        }

        private void OnGetDataOperationCompleted(object arg)
        {
            if ((this.GetDataCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDataCompleted(this, new GetDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/GetDataUsingDataContract", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public CompositeType GetDataUsingDataContract([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] CompositeType composite)
        {
            object[] results = this.Invoke("GetDataUsingDataContract", new object[] {
                        composite});
            return ((CompositeType)(results[0]));
        }

        /// <remarks/>
        public void GetDataUsingDataContractAsync(CompositeType composite)
        {
            this.GetDataUsingDataContractAsync(composite, null);
        }

        /// <remarks/>
        public void GetDataUsingDataContractAsync(CompositeType composite, object userState)
        {
            if ((this.GetDataUsingDataContractOperationCompleted == null))
            {
                this.GetDataUsingDataContractOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDataUsingDataContractOperationCompleted);
            }
            this.InvokeAsync("GetDataUsingDataContract", new object[] {
                        composite}, this.GetDataUsingDataContractOperationCompleted, userState);
        }

        private void OnGetDataUsingDataContractOperationCompleted(object arg)
        {
            if ((this.GetDataUsingDataContractCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDataUsingDataContractCompleted(this, new GetDataUsingDataContractCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/GetShow", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ShowStart.Model")]
        public showstarts[] GetShow()
        {
            object[] results = this.Invoke("GetShow", new object[0]);
            return ((showstarts[])(results[0]));
        }

        /// <remarks/>
        public void GetShowAsync()
        {
            this.GetShowAsync(null);
        }

        /// <remarks/>
        public void GetShowAsync(object userState)
        {
            if ((this.GetShowOperationCompleted == null))
            {
                this.GetShowOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetShowOperationCompleted);
            }
            this.InvokeAsync("GetShow", new object[0], this.GetShowOperationCompleted, userState);
        }

        private void OnGetShowOperationCompleted(object arg)
        {
            if ((this.GetShowCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetShowCompleted(this, new GetShowCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/Login", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Login([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string username, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string password, out int LoginResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool LoginResultSpecified)
        {
            object[] results = this.Invoke("Login", new object[] {
                        username,
                        password});
            LoginResult = ((int)(results[0]));
            LoginResultSpecified = ((bool)(results[1]));
        }

        /// <remarks/>
        public void LoginAsync(string username, string password)
        {
            this.LoginAsync(username, password, null);
        }

        /// <remarks/>
        public void LoginAsync(string username, string password, object userState)
        {
            if ((this.LoginOperationCompleted == null))
            {
                this.LoginOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoginOperationCompleted);
            }
            this.InvokeAsync("Login", new object[] {
                        username,
                        password}, this.LoginOperationCompleted, userState);
        }

        private void OnLoginOperationCompleted(object arg)
        {
            if ((this.LoginCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoginCompleted(this, new LoginCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/Register", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void Register([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string username, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string password, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string email, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string phonenumber, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string sex, [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string accountName, out int RegisterResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool RegisterResultSpecified)
        {
            object[] results = this.Invoke("Register", new object[] {
                        username,
                        password,
                        email,
                        phonenumber,
                        sex,
                        accountName});
            RegisterResult = ((int)(results[0]));
            RegisterResultSpecified = ((bool)(results[1]));
        }

        /// <remarks/>
        public void RegisterAsync(string username, string password, string email, string phonenumber, string sex, string accountName)
        {
            this.RegisterAsync(username, password, email, phonenumber, sex, accountName, null);
        }

        /// <remarks/>
        public void RegisterAsync(string username, string password, string email, string phonenumber, string sex, string accountName, object userState)
        {
            if ((this.RegisterOperationCompleted == null))
            {
                this.RegisterOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRegisterOperationCompleted);
            }
            this.InvokeAsync("Register", new object[] {
                        username,
                        password,
                        email,
                        phonenumber,
                        sex,
                        accountName}, this.RegisterOperationCompleted, userState);
        }

        private void OnRegisterOperationCompleted(object arg)
        {
            if ((this.RegisterCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RegisterCompleted(this, new RegisterCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/GetMonitors", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable = true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ShowStart.Model")]
        public monitor[] GetMonitors([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] string username)
        {
            object[] results = this.Invoke("GetMonitors", new object[] {
                        username});
            return ((monitor[])(results[0]));
        }

        /// <remarks/>
        public void GetMonitorsAsync(string username)
        {
            this.GetMonitorsAsync(username, null);
        }

        /// <remarks/>
        public void GetMonitorsAsync(string username, object userState)
        {
            if ((this.GetMonitorsOperationCompleted == null))
            {
                this.GetMonitorsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetMonitorsOperationCompleted);
            }
            this.InvokeAsync("GetMonitors", new object[] {
                        username}, this.GetMonitorsOperationCompleted, userState);
        }

        private void OnGetMonitorsOperationCompleted(object arg)
        {
            if ((this.GetMonitorsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetMonitorsCompleted(this, new GetMonitorsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/AddMonitors", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void AddMonitors([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] monitor monitor, out bool AddMonitorsResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool AddMonitorsResultSpecified)
        {
            object[] results = this.Invoke("AddMonitors", new object[] {
                        monitor});
            AddMonitorsResult = ((bool)(results[0]));
            AddMonitorsResultSpecified = ((bool)(results[1]));
        }

        /// <remarks/>
        public void AddMonitorsAsync(monitor monitor)
        {
            this.AddMonitorsAsync(monitor, null);
        }

        /// <remarks/>
        public void AddMonitorsAsync(monitor monitor, object userState)
        {
            if ((this.AddMonitorsOperationCompleted == null))
            {
                this.AddMonitorsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddMonitorsOperationCompleted);
            }
            this.InvokeAsync("AddMonitors", new object[] {
                        monitor}, this.AddMonitorsOperationCompleted, userState);
        }

        private void OnAddMonitorsOperationCompleted(object arg)
        {
            if ((this.AddMonitorsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddMonitorsCompleted(this, new AddMonitorsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IService1/DeleteMonitors", RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle = System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteMonitors([System.Xml.Serialization.XmlElementAttribute(IsNullable = true)] monitor monitor, out bool DeleteMonitorsResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool DeleteMonitorsResultSpecified)
        {
            object[] results = this.Invoke("DeleteMonitors", new object[] {
                        monitor});
            DeleteMonitorsResult = ((bool)(results[0]));
            DeleteMonitorsResultSpecified = ((bool)(results[1]));
        }

        /// <remarks/>
        public void DeleteMonitorsAsync(monitor monitor)
        {
            this.DeleteMonitorsAsync(monitor, null);
        }

        /// <remarks/>
        public void DeleteMonitorsAsync(monitor monitor, object userState)
        {
            if ((this.DeleteMonitorsOperationCompleted == null))
            {
                this.DeleteMonitorsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteMonitorsOperationCompleted);
            }
            this.InvokeAsync("DeleteMonitors", new object[] {
                        monitor}, this.DeleteMonitorsOperationCompleted, userState);
        }

        private void OnDeleteMonitorsOperationCompleted(object arg)
        {
            if ((this.DeleteMonitorsCompleted != null))
            {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteMonitorsCompleted(this, new DeleteMonitorsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }

        /// <remarks/>
        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }

        private bool IsLocalFileSystemWebService(string url)
        {
            if (((url == null)
                        || (url == string.Empty)))
            {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024)
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0)))
            {
                return true;
            }
            return false;
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ShowStartWcf")]
    public partial class CompositeType
    {

        private bool boolValueField;

        private bool boolValueFieldSpecified;

        private string stringValueField;

        /// <remarks/>
        public bool BoolValue
        {
            get
            {
                return this.boolValueField;
            }
            set
            {
                this.boolValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BoolValueSpecified
        {
            get
            {
                return this.boolValueFieldSpecified;
            }
            set
            {
                this.boolValueFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string StringValue
        {
            get
            {
                return this.stringValueField;
            }
            set
            {
                this.stringValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ShowStart.Model")]
    public partial class monitor
    {

        private string actorField;

        private long idField;

        private bool idFieldSpecified;

        private string usernameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string actor
        {
            get
            {
                return this.actorField;
            }
            set
            {
                this.actorField = value;
            }
        }

        /// <remarks/>
        public long id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool idSpecified
        {
            get
            {
                return this.idFieldSpecified;
            }
            set
            {
                this.idFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string username
        {
            get
            {
                return this.usernameField;
            }
            set
            {
                this.usernameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://schemas.datacontract.org/2004/07/ShowStart.Model")]
    public partial class showstarts
    {

        private string actorField;

        private string front_image_pathField;

        private string placeField;

        private System.Nullable<decimal> priceField;

        private bool priceFieldSpecified;

        private System.Nullable<System.DateTime> readtimeField;

        private bool readtimeFieldSpecified;

        private string shownameField;

        private System.Nullable<System.DateTime> startimeField;

        private bool startimeFieldSpecified;

        private string typeField;

        private string urlField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string actor
        {
            get
            {
                return this.actorField;
            }
            set
            {
                this.actorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string front_image_path
        {
            get
            {
                return this.front_image_pathField;
            }
            set
            {
                this.front_image_pathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string place
        {
            get
            {
                return this.placeField;
            }
            set
            {
                this.placeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<decimal> price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool priceSpecified
        {
            get
            {
                return this.priceFieldSpecified;
            }
            set
            {
                this.priceFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> readtime
        {
            get
            {
                return this.readtimeField;
            }
            set
            {
                this.readtimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool readtimeSpecified
        {
            get
            {
                return this.readtimeFieldSpecified;
            }
            set
            {
                this.readtimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string showname
        {
            get
            {
                return this.shownameField;
            }
            set
            {
                this.shownameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public System.Nullable<System.DateTime> startime
        {
            get
            {
                return this.startimeField;
            }
            set
            {
                this.startimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool startimeSpecified
        {
            get
            {
                return this.startimeFieldSpecified;
            }
            set
            {
                this.startimeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable = true)]
        public string url
        {
            get
            {
                return this.urlField;
            }
            set
            {
                this.urlField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetDataCompletedEventHandler(object sender, GetDataCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public string Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetDataUsingDataContractCompletedEventHandler(object sender, GetDataUsingDataContractCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDataUsingDataContractCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetDataUsingDataContractCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public CompositeType Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((CompositeType)(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetShowCompletedEventHandler(object sender, GetShowCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetShowCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetShowCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public showstarts[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((showstarts[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void LoginCompletedEventHandler(object sender, LoginCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoginCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal LoginCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public int LoginResult
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }

        /// <remarks/>
        public bool LoginResultSpecified
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void RegisterCompletedEventHandler(object sender, RegisterCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RegisterCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal RegisterCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public int RegisterResult
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }

        /// <remarks/>
        public bool RegisterResultSpecified
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void GetMonitorsCompletedEventHandler(object sender, GetMonitorsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetMonitorsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal GetMonitorsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public monitor[] Result
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((monitor[])(this.results[0]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void AddMonitorsCompletedEventHandler(object sender, AddMonitorsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddMonitorsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal AddMonitorsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public bool AddMonitorsResult
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }

        /// <remarks/>
        public bool AddMonitorsResultSpecified
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void DeleteMonitorsCompletedEventHandler(object sender, DeleteMonitorsCompletedEventArgs e);

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteMonitorsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {

        private object[] results;

        internal DeleteMonitorsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) :
                base(exception, cancelled, userState)
        {
            this.results = results;
        }

        /// <remarks/>
        public bool DeleteMonitorsResult
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }

        /// <remarks/>
        public bool DeleteMonitorsResultSpecified
        {
            get
            {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
}
