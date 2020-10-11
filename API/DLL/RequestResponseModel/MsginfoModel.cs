using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.RequestResponseModel
{
    public class MsginfoModel
    {
        /*
         * App Version Number, length 5, fromat ANS, Mandatory
         * ex: ValidValue:"1.0.0"
         */
        public string versionNo { get; set; }

        /*
         * Message Id, length 17-49, fromat AN, Mandatory
         * It is used to match a response to its request. 
         * The value must be unique on any message and any day. 
         * The value in the response mustmatchthevalueintherequest
         */
        public string msgID { get; set; }

        /*
         * TimeStamp, length 14, fromat N(YYYYMMDDhhmmss), Mandatory
         */
        public string timeStamp { get; set; }

        /* 
         * MessageType, length 1-50, fromat ANS, Mandatory
         */
        public string msgType { get; set; }

        /* 
         * INS ID, length 1-16 , fromat AN, Mandatory
         */
        public string insID { get; set; }
    }
}
