using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.RequestResponseModel
{
    public class UPICardStatusNotificationRequestModel
    {
        public MsginfoModel msgInfo { get; set; }
        public CardStatusNotifyTrxInfoModel cardStatusNotifyTrxInfoModel { get; set; }
    }

    public class CardStatusNotifyTrxInfoModel
    {
        /*
         * Token PAN, length 16-19, fromat N, Mandatory 
         */
        public string token { get; set; }

        /*
         * Token State, length 1-50, fromat ANS, Mandatory 
         * ex:- Validvalues: •“ACTIVE” •“SUSPENDED” •“DELETED”
         */
        public string tokenState { get; set; }
    }
}
