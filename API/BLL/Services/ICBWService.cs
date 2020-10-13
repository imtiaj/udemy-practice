using System;
using System.Threading.Tasks;
using DLL.RequestResponseModel;

namespace BLL.Services
{
    public interface ICBWService
    {
        Task<UPIBaseResponse> AccountUpdateNotification(UPIAccountUpdateNotificationRequestModel requestModel);
        Task<UPIBaseResponse> CardStatusNotification(UPICardStatusNotificationRequestModel requestModel);
        Task<UPIBaseResponseGenerics<TrxResultNotifyTrxInfoModel>> TransactionResultNotification(UPITransactionResultNotificationRequestModel requestModel);
        Task<UPIBaseResponse> AdditionalProcessing(UPIAuditionalProcessingRequestModel requestModel);
    }

    public class CBWService : ICBWService
    {
        public async Task<UPIBaseResponse> AccountUpdateNotification(UPIAccountUpdateNotificationRequestModel requestModel)
        {
            var responseGenObj = new UPIBaseResponse()
            {
                msgInfo = requestModel.msgInfo,
                msgResponse = new MsgResponseModel()
                {
                    responseMsg = "success",
                    responseCode = "200"
                }                
            };
            return responseGenObj;
        }

        public async Task<UPIBaseResponse> AdditionalProcessing(UPIAuditionalProcessingRequestModel requestModel)
        {
            var responseObj = new UPIBaseResponse() 
            {
                msgInfo = requestModel.msgInfo,
                msgResponse = new MsgResponseModel()
                {
                    responseMsg = "success",
                    responseCode = "200"
                }
            };
            return responseObj;
        }

        public async Task<UPIBaseResponse> CardStatusNotification(UPICardStatusNotificationRequestModel requestModel)
        {
            var responseObj = new UPIBaseResponse()
            {
                msgInfo = requestModel.msgInfo,
                msgResponse = new MsgResponseModel()
                {
                    responseMsg = "success",
                    responseCode = "200"
                }
            };
            return responseObj;
        }

        public async Task<UPIBaseResponseGenerics<TrxResultNotifyTrxInfoModel>> TransactionResultNotification(UPITransactionResultNotificationRequestModel requestModel)
        {
            var responseObj = new UPIBaseResponseGenerics<TrxResultNotifyTrxInfoModel>()
            {
                msgInfo = requestModel.msgInfo,
                trxInfo = requestModel.trxResultNotifyTrxInfoModel,
                msgResponse = new MsgResponseModel()
                {
                    responseMsg = "success",
                    responseCode = "200"
                }
            };
            return responseObj;
        }
    }
}
