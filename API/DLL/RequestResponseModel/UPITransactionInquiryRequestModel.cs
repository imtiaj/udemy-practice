using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.RequestResponseModel
{
    public class UPITransactionInquiryRequestModel
    {
        public MsginfoModel msginfo { get; set; }
        public TransactionInquiryTrnxInfo transactionInquiryTrnxInfo { get; set; }
    }

    public class TransactionInquiryTrnxInfo
    {
        public string origTrxId { get; set; }
        public string origTrxType { get; set; }
        public string paymentStatus { get; set; }
        public string rejectionReason { get; set; }
        public string referNo { get; set; }
    }
}
