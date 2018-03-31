﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VelibClientGUI.VelibService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Station", Namespace="http://schemas.datacontract.org/2004/07/IWSVelibLib")]
    [System.SerializableAttribute()]
    public partial class Station : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Available_bikesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int Bike_standsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Available_bikes {
            get {
                return this.Available_bikesField;
            }
            set {
                if ((this.Available_bikesField.Equals(value) != true)) {
                    this.Available_bikesField = value;
                    this.RaisePropertyChanged("Available_bikes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Bike_stands {
            get {
                return this.Bike_standsField;
            }
            set {
                if ((this.Bike_standsField.Equals(value) != true)) {
                    this.Bike_standsField = value;
                    this.RaisePropertyChanged("Bike_stands");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Contract", Namespace="http://schemas.datacontract.org/2004/07/IWSVelibLib")]
    [System.SerializableAttribute()]
    public partial class Contract : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Country_codeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Country_code {
            get {
                return this.Country_codeField;
            }
            set {
                if ((object.ReferenceEquals(this.Country_codeField, value) != true)) {
                    this.Country_codeField = value;
                    this.RaisePropertyChanged("Country_code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VelibService.IVelibService")]
    public interface IVelibService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibService/GetStations", ReplyAction="http://tempuri.org/IVelibService/GetStationsResponse")]
        VelibClientGUI.VelibService.Station[] GetStations(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibService/GetStations", ReplyAction="http://tempuri.org/IVelibService/GetStationsResponse")]
        System.Threading.Tasks.Task<VelibClientGUI.VelibService.Station[]> GetStationsAsync(string city);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibService/GetStation", ReplyAction="http://tempuri.org/IVelibService/GetStationResponse")]
        VelibClientGUI.VelibService.Station GetStation(string city, string stationName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibService/GetStation", ReplyAction="http://tempuri.org/IVelibService/GetStationResponse")]
        System.Threading.Tasks.Task<VelibClientGUI.VelibService.Station> GetStationAsync(string city, string stationName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibService/GetContracts", ReplyAction="http://tempuri.org/IVelibService/GetContractsResponse")]
        VelibClientGUI.VelibService.Contract[] GetContracts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibService/GetContracts", ReplyAction="http://tempuri.org/IVelibService/GetContractsResponse")]
        System.Threading.Tasks.Task<VelibClientGUI.VelibService.Contract[]> GetContractsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVelibServiceChannel : VelibClientGUI.VelibService.IVelibService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VelibServiceClient : System.ServiceModel.ClientBase<VelibClientGUI.VelibService.IVelibService>, VelibClientGUI.VelibService.IVelibService {
        
        public VelibServiceClient() {
        }
        
        public VelibServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VelibServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VelibServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VelibServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public VelibClientGUI.VelibService.Station[] GetStations(string city) {
            return base.Channel.GetStations(city);
        }
        
        public System.Threading.Tasks.Task<VelibClientGUI.VelibService.Station[]> GetStationsAsync(string city) {
            return base.Channel.GetStationsAsync(city);
        }
        
        public VelibClientGUI.VelibService.Station GetStation(string city, string stationName) {
            return base.Channel.GetStation(city, stationName);
        }
        
        public System.Threading.Tasks.Task<VelibClientGUI.VelibService.Station> GetStationAsync(string city, string stationName) {
            return base.Channel.GetStationAsync(city, stationName);
        }
        
        public VelibClientGUI.VelibService.Contract[] GetContracts() {
            return base.Channel.GetContracts();
        }
        
        public System.Threading.Tasks.Task<VelibClientGUI.VelibService.Contract[]> GetContractsAsync() {
            return base.Channel.GetContractsAsync();
        }
    }
}
