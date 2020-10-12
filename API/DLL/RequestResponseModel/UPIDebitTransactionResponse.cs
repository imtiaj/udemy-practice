using System;
namespace DLL.RequestResponseModel
{
    public class UPIDebitTransactionResponse: UPIBaseResponse
    {

        public DebitTransactionInformation trxInfo { get; set; }
    }

}