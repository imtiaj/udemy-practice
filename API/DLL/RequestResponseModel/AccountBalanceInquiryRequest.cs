using System;
namespace DLL.RequestResponseModel
{
    public class AccountBalanceInquiryRequest
    {
        public MsginfoModel msgInfo { get; set; }

        public AccountBalanceInquiryTrxInfo trxInfo { get; set; }
    }

    public class AccountBalanceInquiryTrxInfo
    {
        public AccountInfoModel accountInfo { get; set; }
        public BalanceItem[] balList { get; set; }
        public string referNo { get; set; }
    }
}
