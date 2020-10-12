using System;
using System.Threading.Tasks;
using DLL.RequestResponseModel;

namespace BLL.Services
{
    public interface ICBCardService
    {
        Task<UPIBaseResponse> CreditTransactionProcessAsync(UPICreditTransactionRequest uPIDebitTransactionRequest);
        Task<UPIBaseResponse> DebitTransactionProcessAsync(UPIDebitTransactionRequest uPIDebitTransactionRequest);
    }

    public class CBCardService: ICBCardService
    {
        public async Task<UPIBaseResponse> CreditTransactionProcessAsync(UPICreditTransactionRequest uPIDebitTransactionRequest)
        {
            var newItem = new UPIBaseResponse();
        
            return newItem;
        }

        public async Task<UPIBaseResponse> DebitTransactionProcessAsync(UPIDebitTransactionRequest uPIDebitTransactionRequest)
        {
            var newItem = new UPIBaseResponse();

            return newItem;
        }

    }
}
