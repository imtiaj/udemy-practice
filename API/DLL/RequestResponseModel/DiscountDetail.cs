using System;
namespace DLL.Models
{
    //API to AppGateway 1.3.9
    public class DiscountDetail
    {
        //Bill Number, length: 1-25, Format: AN, M/O/C: C,  Description: Present if the ID "01" under template "62" exists in the Merchant Presented QRC.
        public string BillNo { get; set; }

        //Mobile Number, length: 1-25, Format: ANS, M/O/C: C,  Description: Present if the ID "02" under template "62" exists in the Merchant Presented QRC.
        public string MobileNo { get; set; }

        //store Label, length: 1-25, Format: ANS, M/O/C: C,  Description: Present if the ID "03" under template "63" exists in the Merchant Presented QRC.
        public string StoreLabel { get; set; }

        //loyaltyNumber, length: 1-25, Format: ANS, M/O/C: C,  Description: Present if the ID "04" under template "63" exists in the Merchant Presented QRC.
        public string LoyaltyNumber { get; set; }

        //referenceLabel, length: 1-25, Format: ANS, M/O/C: C,  Description: Present if the ID "05" under template "64" exists in the Merchant Presented QRC.
        public string ReferenceLabel { get; set; }

        //customerLabel, length: 1-25, Format: ANS, M/O/C: C,  Description: Present if the ID "06" under template "64" exists in the Merchant Presented QRC.
        public string CustomerLabel { get; set; }

        //terminalLabel, length: 1-25, Format: ANS, M/O/C: C,  Description: Present if the ID "07" under template "64" exists in the Merchant Presented QRC.
        public string TerminalLabel { get; set; }

        //trxPurpose, length: 1-25, Format: S, M/O/C: C,  Description: Present if the ID "08" under template "65" exists in the Merchant Presented QRC.
        public string TrxPurpose { get; set; }

        //consumerEmail, length: 1-100, Format: S, M/O/C: C,  Description: Present if the ID "09" under template "62" contains value "E" in the Merchant Presented QRC
        public string ConsumerEmail { get; set; }

        //consumerAddress, length: 1-100, Format: S, M/O/C: C,  Description: Present if the ID "09" under template "62" contains value "A" in the Merchant Presented QRC
        public string ConsumerAddress { get; set; }

        //consumerMobileNo, length: 1-25, Format: ANS, M/O/C: C,  Description: Present if the ID "09" under template "62" contains value "M" in the Merchant Presented QRC
        public string ConsumerMobileNo { get; set; }
    }
}
