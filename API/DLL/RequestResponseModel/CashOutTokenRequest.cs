using System;
namespace DLL.RequestResponseModel
{
    public class CashOutTokenRequest
    {
        public MsginfoModel msgInfo { get; set; }
        public CashOutTokenTrxInfo trxInfo { get; set; }
    }

    public class CashOutTokenTrxInfo
    {
        public string trxTokenType { get; set; }
        public string trxToken { get; set; }
        public string debitAccountInfo { get; set; }

        public string trxAmt { get; set; }
        public string trxCurrency { get; set; }
        public string referNo { get; set; }
    }

    public class CashOutTokenResponse
    {
        public MsginfoModel msgInfo { get; set; }
        public CashOutTokenTrxInfo trxInfo { get; set; }
        public MsgResponseModel msgResponse { get; set; }
    }
}
