using System;
using System.Threading.Tasks;
using DLL.RequestResponseModel;

namespace BLL.Services
{
    public interface ICBCardService
    {
        Task<UPIBaseResponse> AccountBalanceInquiryProcessAsync(UPIAccountBalanceInquiryRequest accountBalanceInquiryRequest);
        Task<UPIBaseResponse> CreditTransactionProcessAsync(UPICreditTransactionRequest uPICreditTransactionRequest);
        Task<UPIBaseResponse> DebitTransactionProcessAsync(UPIDebitTransactionRequest uPIDebitTransactionRequest);
        Task<UPIBaseResponse> GetCashOutTokenProcessAsync(UPICashOutTokenRequest cashOutTokenRequest);
        Task<UPIBaseResponse> KycVerificationProcessAsync(UPIKycVerificationRequest uPIKycVerificationRequest);
        Task<UPIBaseResponse> MerchantVerificationProcessAsync(UPIMerchantVerificationRequest uPIMerchantVerificationRequest);

    }

    public class CBCardService: ICBCardService
    {
        public async Task<UPIBaseResponse> AccountBalanceInquiryProcessAsync(UPIAccountBalanceInquiryRequest accountBalanceInquiryRequest)
        {
            var newItem = new UPIBaseResponse();

            return newItem;
        }

        public async Task<UPIBaseResponse> CreditTransactionProcessAsync(UPICreditTransactionRequest uPICreditTransactionRequest)
        {
            var newItem = new UPIBaseResponse();
        
            return newItem;
        }

        public async Task<UPIBaseResponse> DebitTransactionProcessAsync(UPIDebitTransactionRequest uPIDebitTransactionRequest)
        {
            var newItem = new UPIBaseResponse();

            return newItem;
        }

        public async Task<UPIBaseResponse> GetCashOutTokenProcessAsync(UPICashOutTokenRequest cashOutTokenRequest)
        {
            var newItem = new UPIBaseResponse();

            return newItem;
        }

        public async Task<UPIBaseResponse> KycVerificationProcessAsync(UPIKycVerificationRequest uPIKycVerificationRequest)
        {
            var newItem = new UPIBaseResponse();

            return newItem;
        }

        public async Task<UPIBaseResponse> MerchantVerificationProcessAsync(UPIMerchantVerificationRequest uPIMerchantVerificationRequest)
        {
            var newItem = new UPIBaseResponse();

            return newItem;
        }

    }
}
