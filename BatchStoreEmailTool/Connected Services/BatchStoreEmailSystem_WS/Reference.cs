﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BatchStoreEmailTool.BatchStoreEmailSystem_WS {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://tempuri.org/CRSAPImportManager_WS/Common", ConfigurationName="BatchStoreEmailSystem_WS.CommonSoap")]
    public interface CommonSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CRSAPImportManager_WS/Common/GetWebServiceTimeOut", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int GetWebServiceTimeOut();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CRSAPImportManager_WS/Common/GetWebServiceTimeOut", ReplyAction="*")]
        System.Threading.Tasks.Task<int> GetWebServiceTimeOutAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CRSAPImportManager_WS/Common/GetSitesForCompany", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetSitesForCompany(string CompanyID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CRSAPImportManager_WS/Common/GetSitesForCompany", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetSitesForCompanyAsync(string CompanyID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CRSAPImportManager_WS/Common/GetSitesForCompany_v2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetSitesForCompany_v2(string CompanyID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CRSAPImportManager_WS/Common/GetSitesForCompany_v2", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetSitesForCompany_v2Async(string CompanyID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CRSAPImportManager_WS/Common/GetCompanyList", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet GetCompanyList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CRSAPImportManager_WS/Common/GetCompanyList", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetCompanyListAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CommonSoapChannel : BatchStoreEmailTool.BatchStoreEmailSystem_WS.CommonSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CommonSoapClient : System.ServiceModel.ClientBase<BatchStoreEmailTool.BatchStoreEmailSystem_WS.CommonSoap>, BatchStoreEmailTool.BatchStoreEmailSystem_WS.CommonSoap {
        
        public CommonSoapClient() {
        }
        
        public CommonSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CommonSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CommonSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CommonSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetWebServiceTimeOut() {
            return base.Channel.GetWebServiceTimeOut();
        }
        
        public System.Threading.Tasks.Task<int> GetWebServiceTimeOutAsync() {
            return base.Channel.GetWebServiceTimeOutAsync();
        }
        
        public System.Data.DataSet GetSitesForCompany(string CompanyID) {
            return base.Channel.GetSitesForCompany(CompanyID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetSitesForCompanyAsync(string CompanyID) {
            return base.Channel.GetSitesForCompanyAsync(CompanyID);
        }
        
        public System.Data.DataSet GetSitesForCompany_v2(string CompanyID) {
            return base.Channel.GetSitesForCompany_v2(CompanyID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetSitesForCompany_v2Async(string CompanyID) {
            return base.Channel.GetSitesForCompany_v2Async(CompanyID);
        }
        
        public System.Data.DataSet GetCompanyList() {
            return base.Channel.GetCompanyList();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetCompanyListAsync() {
            return base.Channel.GetCompanyListAsync();
        }
    }
}
