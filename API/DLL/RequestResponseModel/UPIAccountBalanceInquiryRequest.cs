using System;
namespace DLL.RequestResponseModel
{
    public class UPIAccountBalanceInquiryRequest
    {
        public MsginfoModel msgInfo { get; set; }

        public UPIAccountBalanceInquiryTrxInfo trxInfo { get; set; }
    }

    public class UPIAccountBalanceInquiryTrxInfo
    {
        public AccountInfoModel accountInfo { get; set; }
        public BalanceItem[] balList { get; set; }
        public string referNo { get; set; }
    }
}
