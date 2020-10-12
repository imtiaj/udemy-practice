using System;
namespace DLL.RequestResponseModel
{
    public class UPIKycVerificationRequest
    {
        public MsginfoModel msgInfo { get; set; }
        public UPIKycVerificationTrxInfo trxInfo { get; set; }
    }


    public class UPIKycVerificationTrxInfo
    {
        public string insPrd { get; set; }
        public string cvmInfo { get; set; } //CVMINFO enccrypted
        public string referNo { get; set; }
    }

    public class UPIKycVerificationResponse
    {
        public MsginfoModel msgInfo { get; set; }
        public UPIKycVerificationTrxInfo trxInfo { get; set; }
        public MsgResponseModel msgResponse { get; set; }
    }
}
