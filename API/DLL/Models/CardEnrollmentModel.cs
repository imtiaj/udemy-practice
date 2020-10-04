using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.Models
{
    public class CardEnrollmentModel
    {
        public Msginfo msgInfo { get; set; }
        public Trxinfo trxInfo { get; set; }
        public MsgResponse msgResponse { get; set; }
    }

    public class Msginfo
    {
        public string versionNo { get; set; }
        public string msgID { get; set; }
        public string timeStamp { get; set; }
        public string msgType { get; set; }
        public string insID { get; set; }
    }

    public class Trxinfo
    {
        public string deviceID { get; set; }
        public string userID { get; set; }
        public string prdNo { get; set; }
        public Cvminfo cvmInfoObj { get; set; }
        public string strCvmInfo { get; set; }
    }

    public class Cvminfo
    {
        public string Pan { get; set; }
        public string accountNo { get; set; }
        public string expiryDate { get; set; }
        public string cvn2 { get; set; }
        public string firstName { get; set; }
        public string midName { get; set; }
        public string lastName { get; set; }
        public string mobileNo { get; set; }
        public string idType { get; set; }
        public string idNo { get; set; }
        public string idCountry { get; set; }
    }

    public class MsgResponse
    {
        public string MyProperty { get; set; }
        public string responseMsg { get; set; }
    }
}
