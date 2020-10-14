using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.RequestResponseModel
{
    public class TrxinfoModel
    {
        public string deviceID { get; set; }
        public string userID { get; set; }
        public string prdNo { get; set; }
        public CvminfoModel cvmInfoObj { get; set; }
        public string strCvmInfo { get; set; }
    }
}
