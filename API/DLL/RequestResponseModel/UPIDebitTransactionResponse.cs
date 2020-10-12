using System;
namespace DLL.RequestResponseModel
{
    public class UPIDebitTransactionResponse
    {
        public MsginfoModel msgInfo { get; set; }

        public DebitTransactionInformation trxInfo { get; set; }

        public MsgResponseModel msgResponse { get; set; }
    }
}