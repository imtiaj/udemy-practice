using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.RequestResponseModel
{
    public class UPIOpenAccountRequestModel
    {
        public MsginfoModel msginfo { get; set; }
        public OpenAccountTrnxInfo openAccountTrnxInfo { get; set; }
    }

    public class OpenAccountTrnxInfo
    {
        public string insPrd { get; set; }
        public string userID { get; set; }
        public string cvminfo { get; set; }
        public CvmAddTLDocmModel cvmAddTLDocm { get; set; }
        public string accountInfo { get; set; }
        public string referNo { get; set; }
    }
}
