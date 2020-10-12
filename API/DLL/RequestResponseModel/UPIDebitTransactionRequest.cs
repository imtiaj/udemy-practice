using System;
namespace DLL.RequestResponseModel
{
    public class UPIDebitTransactionRequest
    {
        // Balance Currency, length: 3, Format: MerchantInfo Obj, Reuest: M, “msgType” value is “DEBIT_TRANSACTION”
        public MerchantInfoModel MsgInfo { get; set; }

        //Balance Amount, length: 1-13, ANS, Mandatory
        public DebitTransactionInformation trxInfo { get; set; }

    }

    public class DebitTransactionInformation
    {
        // relTrxMsgID, length: 17-49, Format: AN, Reuest: O, 
        public String relTrxMsgID { get; set; }

        //Related Transaction Type
        public string relTrxType { get; set; }

    }
}
