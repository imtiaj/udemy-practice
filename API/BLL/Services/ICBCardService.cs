using System;
using System.Threading.Tasks;
using DLL.RequestResponseModel;

namespace BLL.Services
{
    public interface ICBCardService
    {
        Task<UPICreditTransactionResponse> CreditTransactionProcessAsync(UPICreditTransactionRequest uPIDebitTransactionRequest);
        Task<UPIDebitTransactionResponse> DebitTransactionProcessAsync(UPIDebitTransactionRequest uPIDebitTransactionRequest);
    }

    public class CBCardService: ICBCardService
    {
        public async Task<UPICreditTransactionResponse> CreditTransactionProcessAsync(UPICreditTransactionRequest uPIDebitTransactionRequest)
        {
            var newItem = new UPICreditTransactionResponse();
        
            return newItem;
        }

        public async Task<UPIDebitTransactionResponse> DebitTransactionProcessAsync(UPIDebitTransactionRequest uPIDebitTransactionRequest)
        {
            var newItem = new UPIDebitTransactionResponse();

            return newItem;
        }

    }
}
