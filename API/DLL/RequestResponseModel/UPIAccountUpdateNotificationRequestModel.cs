using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.RequestResponseModel
{
    public class UPIAccountUpdateNotificationRequestModel
    {
        /*
         * Message Information, 
         */
        public MsginfoModel msgInfo { get; set; }
        public AccUpdateNotifyTrxInfoModel accUpdateNotifyTrxInfoModel { get; set; }
    }

    public class AccUpdateNotifyTrxInfoModel
    {
        public string accountInfo { get; set; }
        public string referNo { get; set; }
    }
}
