using System;
using System.Threading.Tasks;
using DLL.RequestResponseModel;

namespace BLL.Services
{
    public interface ICBCardService
    {
        Task<UPIDebitTransactionRequest> DebitTransactionProcessAsync(UPIDebitTransactionRequest uPIDebitTransactionRequest);
    }

    public class CBCardService: ICBCardService
    {
        public async Task<UPIDebitTransactionRequest> DebitTransactionProcessAsync(UPIDebitTransactionRequest uPIDebitTransactionRequest)
        {
            var newItem = new UPIDebitTransactionRequest();
        
            return newItem;
        }

    }
}
