using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.RequestResponseModel
{
    /* API to AppGateway 2.15 */
    public class AuditionalProcessingRequestModel
    {
        public MsginfoModel msgInfo { get; set; }
        public AuditionalProcessingTrxInfoModel auditionalProcessingTrxInfoModel { get; set; }
    }

    public class AuditionalProcessingTrxInfoModel
    {
        /*
         * Device ID, length 1-64, fromat ANS, Mandatory 
         */
        public string deviceID { get; set; }

        /*
         * Token PAN, length 16-19, fromat N, Mandatory 
         */
        public string token { get; set; }

        /*
         * EMV Consumer-presented QRCode Payload, length 1-2048, Array, Conditional 
         * C Either "barcodeCpqrcPayload" or "emvCpqrcPayload" shall be present.
         * The consumer-presented QRcode payload(EMVformat) used in the payment transaction. Only one payload is allowed to be present.
         */
        public string[] emvCpqrcPayload { get; set; }


        /*
         * Barcode Consumer-presented QRCode Payload, length 1-2048, Array, Conditional 
         * C Either "barcodeCpqrcPayload" or "emvCpqrcPayload" shall be present.
         * The consumer-presented QRcode payload(barcode)used in the payment transaction. Only one payload is allowed to be present
         */
        public string[] barcodeCpqrcPayload { get; set; }


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
         * Merchant Name, length 1-40, fromat S, Mandatory
         * The merchant name.The value of this field can be displayed on the mobile application to the cardholder.
         */
        public string merchantName { get; set; }
    }
}
