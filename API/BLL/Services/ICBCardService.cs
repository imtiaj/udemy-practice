using System;
using System.Threading.Tasks;
using DLL.RequestResponseModel;

namespace BLL.Services
{
    public interface ICBCardService
    {
        Task<UPIBaseResponse> AccountBalanceInquiryProcessAsync(AccountBalanceInquiryRequest accountBalanceInquiryRequest);
        Task<UPIBaseResponse> CreditTransactionProcessAsync(UPICreditTransactionRequest uPICreditTransactionRequest);
        Task<UPIBaseResponse> DebitTransactionProcessAsync(UPIDebitTransactionRequest uPIDebitTransactionRequest);
        Task<UPIBaseResponse> GetCashOutTokenProcessAsync(CashOutTokenRequest cashOutTokenRequest);

    }

    public class CBCardService: ICBCardService
    {
        public async Task<UPIBaseResponse> AccountBalanceInquiryProcessAsync(AccountBalanceInquiryRequest accountBalanceInquiryRequest)
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

        public async Task<UPIBaseResponse> GetCashOutTokenProcessAsync(CashOutTokenRequest cashOutTokenRequest)
        {
            var newItem = new UPIBaseResponse();

            return newItem;
        }

    }
}
