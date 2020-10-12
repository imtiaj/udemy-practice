using System;
namespace DLL.RequestResponseModel
{
    public class UPICreditTransactionResponse
    {
        public MsginfoModel msgInfo { get; set; }

        public CreditTransactionInformation trxInfo { get; set; }

        public MsgResponseModel msgResponse { get; set; }
    }
}
