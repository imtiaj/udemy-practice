using System;
namespace DLL.RequestResponseModel
{
    public class UPIMerchantVerificationRequest
    {
        public MsginfoModel msgInfo { get; set; }
        public UPIMerchantVerificationTrxInfo trxInfo { get; set; }
    }

    public class UPIMerchantVerificationTrxInfo
    {
        public MerchantInfoModel merchantInfo { get; set; }
        public string mpqrcPayload { get; set; } //CVMINFO enccrypted
        public string referNo { get; set; }
    }

    public class UPIMerchantVerificationResponse
    {
        public MsginfoModel msgInfo { get; set; }
        public UPIMerchantVerificationTrxInfo trxInfo { get; set; }
        public MsgResponseModel msgResponse { get; set; }
    }
}
