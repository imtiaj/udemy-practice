using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.RequestResponseModel
{
    public class UPITransactionResultNotificationRequestModel
    {
        public MsginfoModel msgInfo { get; set; }
        public TrxResultNotifyTrxInfoModel trxResultNotifyTrxInfoModel { get; set; }
    }

    public class TrxResultNotifyTrxInfoModel
    {
        public string deviceID { get; set; }
        
        /*
         * Token PAN, length 16-19, fromat N, Mandatory 
         */
        public string token { get; set; }

        /*
         * Transaction Message Type , length 1-50, fromat N, Mandatory 
         * Ex for valid values: "CPQRC_PAYMENT", "P2P_TRANSFER", "CANCELLATION", "REFUND", "DEPOSIT", "WITHDRAW"
         */
        public string trxMsgType { get; set; }

        /*
         * Transaction Message Type , length 1-50, fromat ANS, Conditional 
         * C Present if "trxType" is "CANCELLATION" or "REFUND"
         */
        public string origMsgID { get; set; }

        /*
         * Transaction Message Type , length 1-50, fromat ANS, Conditional 
         * C Present if "trxType" is "CANCELLATION" or "REFUND"
         * Ex for valid values: "MPQRC_PAYMENT_EMV",  "MPQRC_PAYMENT_URL",  "CPQRC_PAYMENT",  "P2P_TRANSFER",  "DEPOSIT",  "WITHDRAW",
         */
        public string origTrxType { get; set; }

        /*
         * Account Information , Object, fromat S, Optional
         * Encrypted with the public key of the Encryption Certificate.
         */
        public string accountInfo { get; set; }


        /*
         * Transaction Amount, length 1-13, fromat ANS, Mandatory
         * The mobile application can display the transaction amount to the card holder.
         * Thetransaction amount may be unequal to that in the payment request message due to the discount.
         */
        public string trxAmt { get; set; }


        /*
         * Transaction Currency, length 3, fromat N, Mandatory
         * A 3-digit numeric value,as defined by [ISO 4217], that indicates the currency code of the transaction
         * The mobile application can display the transaction currency inareadable way,such as "RMB"
         */
        public string trxCurrency { get; set; }

        /*
         * Transaction Note, length  1-120, fromat S, Optional
         * Descriptive Information of transaction
         */
        public string trxNote { get; set; }

        /*
         * Reference No, length  1-50, fromat ANS, Optional
         */
        public string referNo { get; set; }
    }
}
