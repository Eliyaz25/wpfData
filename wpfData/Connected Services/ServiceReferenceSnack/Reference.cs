﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wpfData.ServiceReferenceSnack {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="CityList", Namespace="http://schemas.datacontract.org/2004/07/Model", ItemName="City")]
    [System.SerializableAttribute()]
    public class CityList : System.Collections.Generic.List<wpfData.ServiceReferenceSnack.City> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="City", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class City : wpfData.ServiceReferenceSnack.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CityName {
            get {
                return this.CityNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CityNameField, value) != true)) {
                    this.CityNameField = value;
                    this.RaisePropertyChanged("CityName");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseEntity", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(wpfData.ServiceReferenceSnack.User))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(wpfData.ServiceReferenceSnack.Snacks))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(wpfData.ServiceReferenceSnack.City))]
    public partial class BaseEntity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class User : wpfData.ServiceReferenceSnack.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private wpfData.ServiceReferenceSnack.City CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsAdminField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private wpfData.ServiceReferenceSnack.SnacksList MySnacksField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public wpfData.ServiceReferenceSnack.City City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsAdmin {
            get {
                return this.IsAdminField;
            }
            set {
                if ((this.IsAdminField.Equals(value) != true)) {
                    this.IsAdminField = value;
                    this.RaisePropertyChanged("IsAdmin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public wpfData.ServiceReferenceSnack.SnacksList MySnacks {
            get {
                return this.MySnacksField;
            }
            set {
                if ((object.ReferenceEquals(this.MySnacksField, value) != true)) {
                    this.MySnacksField = value;
                    this.RaisePropertyChanged("MySnacks");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Snacks", Namespace="http://schemas.datacontract.org/2004/07/Model")]
    [System.SerializableAttribute()]
    public partial class Snacks : wpfData.ServiceReferenceSnack.BaseEntity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SnackNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private wpfData.ServiceReferenceSnack.UserList UserListField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SnackName {
            get {
                return this.SnackNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SnackNameField, value) != true)) {
                    this.SnackNameField = value;
                    this.RaisePropertyChanged("SnackName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public wpfData.ServiceReferenceSnack.UserList UserList {
            get {
                return this.UserListField;
            }
            set {
                if ((object.ReferenceEquals(this.UserListField, value) != true)) {
                    this.UserListField = value;
                    this.RaisePropertyChanged("UserList");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="SnacksList", Namespace="http://schemas.datacontract.org/2004/07/Model", ItemName="Snacks")]
    [System.SerializableAttribute()]
    public class SnacksList : System.Collections.Generic.List<wpfData.ServiceReferenceSnack.Snacks> {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="UserList", Namespace="http://schemas.datacontract.org/2004/07/Model", ItemName="User")]
    [System.SerializableAttribute()]
    public class UserList : System.Collections.Generic.List<wpfData.ServiceReferenceSnack.User> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceSnack.IServiceSnacks")]
    public interface IServiceSnacks {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnacks/GetAllCities", ReplyAction="http://tempuri.org/IServiceSnacks/GetAllCitiesResponse")]
        wpfData.ServiceReferenceSnack.CityList GetAllCities();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnacks/GetAllCities", ReplyAction="http://tempuri.org/IServiceSnacks/GetAllCitiesResponse")]
        System.Threading.Tasks.Task<wpfData.ServiceReferenceSnack.CityList> GetAllCitiesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnacks/GetAllUsers", ReplyAction="http://tempuri.org/IServiceSnacks/GetAllUsersResponse")]
        wpfData.ServiceReferenceSnack.UserList GetAllUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnacks/GetAllUsers", ReplyAction="http://tempuri.org/IServiceSnacks/GetAllUsersResponse")]
        System.Threading.Tasks.Task<wpfData.ServiceReferenceSnack.UserList> GetAllUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnacks/GetAllSnacks", ReplyAction="http://tempuri.org/IServiceSnacks/GetAllSnacksResponse")]
        wpfData.ServiceReferenceSnack.SnacksList GetAllSnacks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnacks/GetAllSnacks", ReplyAction="http://tempuri.org/IServiceSnacks/GetAllSnacksResponse")]
        System.Threading.Tasks.Task<wpfData.ServiceReferenceSnack.SnacksList> GetAllSnacksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnacks/GetSnacksByUser", ReplyAction="http://tempuri.org/IServiceSnacks/GetSnacksByUserResponse")]
        wpfData.ServiceReferenceSnack.SnacksList GetSnacksByUser(wpfData.ServiceReferenceSnack.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnacks/GetSnacksByUser", ReplyAction="http://tempuri.org/IServiceSnacks/GetSnacksByUserResponse")]
        System.Threading.Tasks.Task<wpfData.ServiceReferenceSnack.SnacksList> GetSnacksByUserAsync(wpfData.ServiceReferenceSnack.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnacks/GetUserBySnack", ReplyAction="http://tempuri.org/IServiceSnacks/GetUserBySnackResponse")]
        wpfData.ServiceReferenceSnack.UserList GetUserBySnack(wpfData.ServiceReferenceSnack.Snacks snack);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnacks/GetUserBySnack", ReplyAction="http://tempuri.org/IServiceSnacks/GetUserBySnackResponse")]
        System.Threading.Tasks.Task<wpfData.ServiceReferenceSnack.UserList> GetUserBySnackAsync(wpfData.ServiceReferenceSnack.Snacks snack);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnacks/Login", ReplyAction="http://tempuri.org/IServiceSnacks/LoginResponse")]
        wpfData.ServiceReferenceSnack.User Login(wpfData.ServiceReferenceSnack.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceSnacks/Login", ReplyAction="http://tempuri.org/IServiceSnacks/LoginResponse")]
        System.Threading.Tasks.Task<wpfData.ServiceReferenceSnack.User> LoginAsync(wpfData.ServiceReferenceSnack.User user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceSnacksChannel : wpfData.ServiceReferenceSnack.IServiceSnacks, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceSnacksClient : System.ServiceModel.ClientBase<wpfData.ServiceReferenceSnack.IServiceSnacks>, wpfData.ServiceReferenceSnack.IServiceSnacks {
        
        public ServiceSnacksClient() {
        }
        
        public ServiceSnacksClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceSnacksClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSnacksClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceSnacksClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public wpfData.ServiceReferenceSnack.CityList GetAllCities() {
            return base.Channel.GetAllCities();
        }
        
        public System.Threading.Tasks.Task<wpfData.ServiceReferenceSnack.CityList> GetAllCitiesAsync() {
            return base.Channel.GetAllCitiesAsync();
        }
        
        public wpfData.ServiceReferenceSnack.UserList GetAllUsers() {
            return base.Channel.GetAllUsers();
        }
        
        public System.Threading.Tasks.Task<wpfData.ServiceReferenceSnack.UserList> GetAllUsersAsync() {
            return base.Channel.GetAllUsersAsync();
        }
        
        public wpfData.ServiceReferenceSnack.SnacksList GetAllSnacks() {
            return base.Channel.GetAllSnacks();
        }
        
        public System.Threading.Tasks.Task<wpfData.ServiceReferenceSnack.SnacksList> GetAllSnacksAsync() {
            return base.Channel.GetAllSnacksAsync();
        }
        
        public wpfData.ServiceReferenceSnack.SnacksList GetSnacksByUser(wpfData.ServiceReferenceSnack.User user) {
            return base.Channel.GetSnacksByUser(user);
        }
        
        public System.Threading.Tasks.Task<wpfData.ServiceReferenceSnack.SnacksList> GetSnacksByUserAsync(wpfData.ServiceReferenceSnack.User user) {
            return base.Channel.GetSnacksByUserAsync(user);
        }
        
        public wpfData.ServiceReferenceSnack.UserList GetUserBySnack(wpfData.ServiceReferenceSnack.Snacks snack) {
            return base.Channel.GetUserBySnack(snack);
        }
        
        public System.Threading.Tasks.Task<wpfData.ServiceReferenceSnack.UserList> GetUserBySnackAsync(wpfData.ServiceReferenceSnack.Snacks snack) {
            return base.Channel.GetUserBySnackAsync(snack);
        }
        
        public wpfData.ServiceReferenceSnack.User Login(wpfData.ServiceReferenceSnack.User user) {
            return base.Channel.Login(user);
        }
        
        public System.Threading.Tasks.Task<wpfData.ServiceReferenceSnack.User> LoginAsync(wpfData.ServiceReferenceSnack.User user) {
            return base.Channel.LoginAsync(user);
        }
    }
}
