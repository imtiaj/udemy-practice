using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.RequestResponseModel
{
    public class UPIP2PRequestModel
    {
        public MsginfoModel msginfo { get; set; }
        public P2PTrnxInfo p2PTrnxInfo { get; set; }
    }

    public class P2PTrnxInfo
    {
        public string debitAccountInfo { get; set; }
        public string creditAccountInfo { get; set; }
        public string trxAmt { get; set; }
        public string trxCurrency { get; set; }
        public string billAmt { get; set; }
        public string billCurrency { get; set; }
        public string markupAmt { get; set; }
        public string feeAmt { get; set; }
        public string trxNote { get; set; }
        public string settDate { get; set; }
        public string referNo { get; set; }
    }
}
