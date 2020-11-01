using System;
using System.Threading.Tasks;
using DLL.RequestResponseModel;
using Utility.Helpers;
using Utility.SocketClient;

namespace BLL.Services
{
    public interface ICBCardService
    {
        Task<UPIBaseResponseGenerics<UPIAccountBalanceInquiryTrxInfo>> AccountBalanceInquiryProcessAsync(UPIAccountBalanceInquiryRequest accountBalanceInquiryRequest);
        Task<UPIBaseResponseGenerics<CreditTransactionInformation>> CreditTransactionProcessAsync(UPICreditTransactionRequest uPICreditTransactionRequest);
        Task<UPIBaseResponseGenerics<DebitTransactionInformation>> DebitTransactionProcessAsync(UPIDebitTransactionRequest uPIDebitTransactionRequest);
        Task<UPIBaseResponse> GetCashOutTokenProcessAsync(UPICashOutTokenRequest cashOutTokenRequest);
        Task<UPIBaseResponse> KycVerificationProcessAsync(UPIKycVerificationRequest uPIKycVerificationRequest);
        Task<UPIBaseResponse> MerchantVerificationProcessAsync(UPIMerchantVerificationRequest uPIMerchantVerificationRequest);
        Task<UPIBaseResponseGenerics<OpenAccountTrnxInfo>> OpenAccount(UPIOpenAccountRequestModel requestModel);
        Task<UPIBaseResponseGenerics<P2PTrnxInfo>> P2PTransfer(UPIP2PRequestModel requestModel);
        Task<UPIBaseResponseGenerics<ReversalTrnxInfo>> ReversalTransaction(UPIReversalTransactionRequestModel requestModel);
        Task<UPIBaseResponseGenerics<TransactionInquiryTrnxInfo>> TransactionInquiry(UPITransactionInquiryRequestModel requestModel);
    }

    public class CBCardService: ICBCardService
    {
        public async Task<UPIBaseResponseGenerics<UPIAccountBalanceInquiryTrxInfo>> AccountBalanceInquiryProcessAsync(UPIAccountBalanceInquiryRequest accountBalanceInquiryRequest)
        {
            var responseObj = new UPIBaseResponseGenerics<UPIAccountBalanceInquiryTrxInfo>()
            {
                msgInfo = accountBalanceInquiryRequest.msgInfo,
                trxInfo = accountBalanceInquiryRequest.trxInfo,
                msgResponse = new MsgResponseModel()
                {
                    responseMsg = "success",
                    responseCode = "200"
                }
            };
            return responseObj;
        }

        public async Task<UPIBaseResponseGenerics<CreditTransactionInformation>> CreditTransactionProcessAsync(UPICreditTransactionRequest uPICreditTransactionRequest)
        {
            var responseObj = new UPIBaseResponseGenerics<CreditTransactionInformation>()
            {
                msgInfo = uPICreditTransactionRequest.msgInfo,
                trxInfo = uPICreditTransactionRequest.trxInfo,
                msgResponse = new MsgResponseModel()
                {
                    responseMsg = "success",
                    responseCode = "200"
                }
            };
            return responseObj;
        }

        public async Task<UPIBaseResponseGenerics<DebitTransactionInformation>> DebitTransactionProcessAsync(UPIDebitTransactionRequest uPIDebitTransactionRequest)
        {
            var msgInfo = uPIDebitTransactionRequest.msgInfo;
            if (msgInfo.msgType == "DEBIT_TRANSACTION")
            {
                var trncInfo = uPIDebitTransactionRequest.trxInfo;
                var debitAccInfo = trncInfo.debitAccountInfo;
                if(debitAccInfo != null || debitAccInfo != "")
                {
                    var serverAddress = "127.0.0.1";
                    var port = 5001;

                    //Verify Signature
                    //Format: "JWSSignatureVerify-detachedJwsContent-Payload-Publickey"
                    var socket = SocketClient.StartSocketClient(serverAddress, port);

                    var typeForVerify = "ParseJWEContent";
                    var privateKey = KeyManager.getPrivateKey();
                    string parsedJWEContent = SocketClient.ParseJWEContent(socket, typeForVerify, debitAccInfo, privateKey);
                    var serializer = new Serializer();
                    var deserializeData = serializer.Deserialize<AccountInfoModel>(parsedJWEContent);
                }
            }
            else
            {
                // transaction type not valid.
            }
            var responseObj = new UPIBaseResponseGenerics<DebitTransactionInformation>()
            {
                msgInfo = uPIDebitTransactionRequest.msgInfo,
                trxInfo = uPIDebitTransactionRequest.trxInfo,
                msgResponse = new MsgResponseModel()
                {
                    responseMsg = "success",
                    responseCode = "200"
                }
            };
            return responseObj;
        }

        public async Task<UPIBaseResponse> GetCashOutTokenProcessAsync(UPICashOutTokenRequest cashOutTokenRequest)
        {
            var responseObj = new UPIBaseResponse()
            {
                msgInfo = cashOutTokenRequest.msgInfo,
                msgResponse = new MsgResponseModel()
                {
                    responseMsg = "success",
                    responseCode = "200"
                }
            };
            return responseObj;
        }

        public async Task<UPIBaseResponse> KycVerificationProcessAsync(UPIKycVerificationRequest uPIKycVerificationRequest)
        {
            var responseObj = new UPIBaseResponse()
            {
                msgInfo = uPIKycVerificationRequest.msgInfo,
                msgResponse = new MsgResponseModel()
                {
                    responseMsg = "success",
                    responseCode = "200"
                }
            };
            return responseObj;
        }

        public async Task<UPIBaseResponse> MerchantVerificationProcessAsync(UPIMerchantVerificationRequest uPIMerchantVerificationRequest)
        {
            var responseObj = new UPIBaseResponse()
            {
                msgInfo = uPIMerchantVerificationRequest.msgInfo,
                msgResponse = new MsgResponseModel()
                {
                    responseMsg = "success",
                    responseCode = "200"
                }
            };
            return responseObj;
        }

        public async Task<UPIBaseResponseGenerics<OpenAccountTrnxInfo>> OpenAccount(UPIOpenAccountRequestModel requestModel)
        {
            var responseObj = new UPIBaseResponseGenerics<OpenAccountTrnxInfo>()
            {
                msgInfo = requestModel.msginfo,
                trxInfo = requestModel.openAccountTrnxInfo,
                msgResponse = new MsgResponseModel()
                {
                    responseMsg = "success",
                    responseCode = "200"
                }
            };
            return responseObj;
        }


        public async Task<UPIBaseResponseGenerics<P2PTrnxInfo>> P2PTransfer(UPIP2PRequestModel requestModel)
        {
            var responseObj = new UPIBaseResponseGenerics<P2PTrnxInfo>()
            {
                msgInfo = requestModel.msginfo,
                trxInfo = requestModel.p2PTrnxInfo,
                msgResponse = new MsgResponseModel()
                {
                    responseMsg = "success",
                    responseCode = "200"
                }
            };
            return responseObj;
        }

        public async Task<UPIBaseResponseGenerics<ReversalTrnxInfo>> ReversalTransaction(UPIReversalTransactionRequestModel requestModel)
        {
            var responseObj = new UPIBaseResponseGenerics<ReversalTrnxInfo>()
            {
                msgInfo = requestModel.msginfo,
                trxInfo = requestModel.reversalTrnxInfo,
                msgResponse = new MsgResponseModel()
                {
                    responseMsg = "success",
                    responseCode = "200"
                }
            };
            return responseObj;
        }

        public async Task<UPIBaseResponseGenerics<TransactionInquiryTrnxInfo>> TransactionInquiry(UPITransactionInquiryRequestModel requestModel)
        {
            var responseObj = new UPIBaseResponseGenerics<TransactionInquiryTrnxInfo>()
            {
                msgInfo = requestModel.msginfo,
                trxInfo = requestModel.transactionInquiryTrnxInfo,
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
