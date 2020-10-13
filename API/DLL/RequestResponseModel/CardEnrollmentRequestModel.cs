using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.RequestResponseModel
{
    public class CardEnrollmentRequestModel
    {
        public string deviceID { get; set; }
        public string cvminfo { get; set; }
        public string pin { get; set; }
    }
}
