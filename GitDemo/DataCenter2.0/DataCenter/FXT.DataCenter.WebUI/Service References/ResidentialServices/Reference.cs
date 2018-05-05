﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18063
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FXT.DataCenter.WebUI.ResidentialServices
{


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "ResidentialServices.IResidential")]
    public interface IResidential
    {

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, Action = "http://tempuri.org/IResidential/DeleteSameProjectCase")]
        void DeleteSameProjectCase(int fxtCompanyId, int cityId, System.DateTime caseDateFrom, System.DateTime caseDateTo, string saveUser);

        [System.ServiceModel.OperationContractAttribute(IsOneWay = true, AsyncPattern = true, Action = "http://tempuri.org/IResidential/DeleteSameProjectCase")]
        System.IAsyncResult BeginDeleteSameProjectCase(int fxtCompanyId, int cityId, System.DateTime caseDateFrom, System.DateTime caseDateTo, string saveUser, System.AsyncCallback callback, object asyncState);

        void EndDeleteSameProjectCase(System.IAsyncResult result);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IResidentialChannel : FXT.DataCenter.WebUI.ResidentialServices.IResidential, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ResidentialClient : System.ServiceModel.ClientBase<FXT.DataCenter.WebUI.ResidentialServices.IResidential>, FXT.DataCenter.WebUI.ResidentialServices.IResidential
    {

        private BeginOperationDelegate onBeginDeleteSameProjectCaseDelegate;

        private EndOperationDelegate onEndDeleteSameProjectCaseDelegate;

        private System.Threading.SendOrPostCallback onDeleteSameProjectCaseCompletedDelegate;

        public ResidentialClient()
        {
        }

        public ResidentialClient(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public ResidentialClient(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public ResidentialClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public ResidentialClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> DeleteSameProjectCaseCompleted;

        public void DeleteSameProjectCase(int fxtCompanyId, int cityId, System.DateTime caseDateFrom, System.DateTime caseDateTo, string saveUser)
        {
            base.Channel.DeleteSameProjectCase(fxtCompanyId, cityId, caseDateFrom, caseDateTo, saveUser);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginDeleteSameProjectCase(int fxtCompanyId, int cityId, System.DateTime caseDateFrom, System.DateTime caseDateTo, string saveUser, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginDeleteSameProjectCase(fxtCompanyId, cityId, caseDateFrom, caseDateTo, saveUser, callback, asyncState);
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public void EndDeleteSameProjectCase(System.IAsyncResult result)
        {
            base.Channel.EndDeleteSameProjectCase(result);
        }

        private System.IAsyncResult OnBeginDeleteSameProjectCase(object[] inValues, System.AsyncCallback callback, object asyncState)
        {
            int fxtCompanyId = ((int)(inValues[0]));
            int cityId = ((int)(inValues[1]));
            System.DateTime caseDateFrom = ((System.DateTime)(inValues[2]));
            System.DateTime caseDateTo = ((System.DateTime)(inValues[3]));
            string saveUser = inValues[4].ToString();
            return this.BeginDeleteSameProjectCase(fxtCompanyId, cityId, caseDateFrom, caseDateTo, saveUser, callback, asyncState);
        }

        private object[] OnEndDeleteSameProjectCase(System.IAsyncResult result)
        {
            this.EndDeleteSameProjectCase(result);
            return null;
        }

        private void OnDeleteSameProjectCaseCompleted(object state)
        {
            if ((this.DeleteSameProjectCaseCompleted != null))
            {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DeleteSameProjectCaseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }

        public void DeleteSameProjectCaseAsync(int fxtCompanyId, int cityId, System.DateTime caseDateFrom, System.DateTime caseDateTo, string saveUser)
        {
            this.DeleteSameProjectCaseAsync(fxtCompanyId, cityId, caseDateFrom, caseDateTo, saveUser, null);
        }

        public void DeleteSameProjectCaseAsync(int fxtCompanyId, int cityId, System.DateTime caseDateFrom, System.DateTime caseDateTo, string saveUser, object userState)
        {
            if ((this.onBeginDeleteSameProjectCaseDelegate == null))
            {
                this.onBeginDeleteSameProjectCaseDelegate = new BeginOperationDelegate(this.OnBeginDeleteSameProjectCase);
            }
            if ((this.onEndDeleteSameProjectCaseDelegate == null))
            {
                this.onEndDeleteSameProjectCaseDelegate = new EndOperationDelegate(this.OnEndDeleteSameProjectCase);
            }
            if ((this.onDeleteSameProjectCaseCompletedDelegate == null))
            {
                this.onDeleteSameProjectCaseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDeleteSameProjectCaseCompleted);
            }
            base.InvokeAsync(this.onBeginDeleteSameProjectCaseDelegate, new object[] {
                        fxtCompanyId,
                        cityId,
                        caseDateFrom,
                        caseDateTo,saveUser}, this.onEndDeleteSameProjectCaseDelegate, this.onDeleteSameProjectCaseCompletedDelegate, userState);
        }
    }
}