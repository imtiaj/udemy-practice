using System;
namespace DLL.RequestResponseModel
{
    //API to AppGateway 1.3.14
    public class BalanceItem
    {
        // Balance Currency, length: 3, N,  Mandatory, A 3-digit numeric value, as defined by [ISO 4217], that indicates the currency code of the balance.
        public int BalCurrency { get; set; }

        //Balance Amount, length: 1-13, ANS, Mandatory
        public string BalAmt { get; set; }

        //Available Amount, length: 1-13, ANS, Mandatory
        public string AvailableAmt { get; set; }
    }
}
