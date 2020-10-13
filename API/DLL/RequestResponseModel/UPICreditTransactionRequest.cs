using System;
namespace DLL.RequestResponseModel
{
    public class UPICreditTransactionRequest
    {
        public MsginfoModel msgInfo { get; set; }

        public CreditTransactionInformation trxInfo { get; set; }
    }

    public class CreditTransactionInformation
    {
        //length: 17-49, Format: AN, Reuest: O, 
        public String relTrxMsgID { get; set; }
        public string relTrxType { get; set; }  //length: 1-50, Format: ANS, Reuest: O, valid values: "MPQRC_PAYMENT", "CPQRC_PAYMENT", "BILL_PAYMENT", "DISPUTE", "AUTH_COMPLETION".
        public string authID { get; set; }  //length: 6, Format: AN, Reuest: C, 
        public string origMsgID { get; set; }
        public string origMsgType { get; set; }
        public MerchantInfoModel merchantInfo { get; set; }
        public string onUsFlag { get; set; }
        public AccountInfoModel creditAccountInfo { get; set; }
        public string trxAmt { get; set; }
        public string trxCurrency { get; set; }
        public DiscountDetail discountDetails { get; set; }  // Enccrypted
        public string billAmt { get; set; }
        public string billCurrency { get; set; }
        public string markupAmt { get; set; }
        public string feeAmt { get; set; }
        public string billConvRate { get; set; }
        public string settAmt { get; set; }
        public string settCurrency { get; set; }
        public string settConvRate { get; set; }
        public string convDate { get; set; }
        public string trxNote { get; set; }
        public string settDate { get; set; }
        public string posEntryModeCode { get; set; }
        public string retrivlRefNum { get; set; }
        public string transDatetime { get; set; }
        public string traceNum { get; set; }
        public string appOrderNo { get; set; }
        public string referNo { get; set; }
    }
}
