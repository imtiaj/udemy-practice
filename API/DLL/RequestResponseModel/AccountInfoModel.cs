using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.RequestResponseModel
{
    public class AccountInfoModel
    {
        public string token { get; set; }
        public string pan { get; set; }
        public string accountNo { get; set; }
        public string firstName { get; set; }
        public string midName { get; set; }
        public string lastName { get; set; }
        public string accountStatus { get; set; }
        public string accountTier { get; set; }
        public string countryCode { get; set; }
    }
}
