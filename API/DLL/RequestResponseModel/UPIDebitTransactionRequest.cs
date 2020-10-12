using System;
namespace DLL.RequestResponseModel
{
    public class UPIDebitTransactionRequest
    {
        // Balance Currency, length: 3, N,  Mandatory, A 3-digit numeric value, as defined by [ISO 4217], that indicates the currency code of the balance.
        public MerchantInfoModel MsgInfo { get; set; }

        //Balance Amount, length: 1-13, ANS, Mandatory
        public string BalAmt { get; set; }

        //Available Amount, length: 1-13, ANS, Mandatory
        public string AvailableAmt { get; set; }
    }
}
