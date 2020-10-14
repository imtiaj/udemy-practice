using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.RequestResponseModel
{
    public class MerchantInfoModel
    {
        public string acquirerIIN { get; set; }
        public string fwdIIN { get; set; }
        public string mid { get; set; }
        public string merchantName { get; set; }
        public Int64 mcc { get; set; }
        public string merchantCountry { get; set; }
        public string termId { get; set; }
        public string agentCode { get; set; }
    }
}
