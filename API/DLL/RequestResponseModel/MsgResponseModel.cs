using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.RequestResponseModel
{
    public class MsgResponseModel
    {
        /*
         * ResponseCode, length 2, fromat AN, Mandatory
         * It contains a code that defines the response to a request. 
         * Please refer to the Response Code and Message for the valid values. 
         */
        public string responseCode { get; set; }

        /*
         * ResponseCode, length 1-100, fromat S, Mandatory
         * It contains the transaction result and the rejection reason if the transaction fails.
         */
        public string responseMsg { get; set; }
    }
}
