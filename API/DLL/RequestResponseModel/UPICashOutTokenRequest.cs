using System;
namespace DLL.RequestResponseModel
{
    public class UPICashOutTokenRequest
    {
        public MsginfoModel msgInfo { get; set; }
        public UPICashOutTokenTrxInfo trxInfo { get; set; }
    }

    public class UPICashOutTokenTrxInfo
    {
        public string trxTokenType { get; set; }
        public string trxToken { get; set; }
        public string debitAccountInfo { get; set; }

        public string trxAmt { get; set; }
        public string trxCurrency { get; set; }
        public string referNo { get; set; }
    }

    public class UPICashOutTokenResponse
    {
        public MsginfoModel msgInfo { get; set; }
        public UPICashOutTokenTrxInfo trxInfo { get; set; }
        public MsgResponseModel msgResponse { get; set; }
    }
}
