using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.RequestResponseModel
{
    public class UPIReversalTransactionRequestModel
    {
        public MsginfoModel msginfo { get; set; }
        public ReversalTrnxInfo reversalTrnxInfo { get; set; }
    }

    public class ReversalTrnxInfo
    {
        public string origMsgId { get; set; }
        public string origMsgType { get; set; }
        public string trxAmt { get; set; }
        public string trxCurrency { get; set; }
        public string billAmt { get; set; }
        public string billCurrency { get; set; }
        public string markupAmt { get; set; }
        public string feeAmt { get; set; }
        public string billConvRate { get; set; }
        public string settAmt { get; set; }
        public string settCurrency { get; set; }
        public string settConvRate { get; set; }
        public string convDate { get; set; }
        public MerchantInfoModel merchantInfo { get; set; }
        public string trxNote { get; set; }
        public string posEntryModeCode { get; set; }
        public string retrivlRefNum { get; set; }
        public string transDatetime { get; set; }
        public string traceNum { get; set; }
        public string referNo { get; set; }

    }
}
