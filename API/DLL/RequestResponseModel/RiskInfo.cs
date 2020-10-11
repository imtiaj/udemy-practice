using System;
namespace DLL.RequestResponseModel
{
    public class RiskInfo
    {
        //GPS, length: 1-64, Format: ANS, M/O/C: O,  Description: Components: +(-) latitude/+(-) longitude
        public string gps { get; set; }

        //SIM Card, length: 1-200, Format: Array, M/O/C: O,  Description:
        public string simCard { get; set; }

        //Application User ID, length: 1-64, Format: ANS, M/O/C: O,  Description:
        public string appUserID { get; set; }

        //User Enrollment Date, length: 6, Format: N(YYMMDD), M/O/C: O,  Description:
        public string usrEnrolDate { get; set; }

        //Card Number Capture Method, length: 1-64, Format: ANS, M/O/C: O,  Description: valid values: MANUAL, NFC, CAMERA, UNKNOWN
        public string captureMethod { get; set; }

        //IP Address, length: 1-64, Format: ANS, M/O/C: O,  Description:
        public string ipAddress { get; set; }

        //Reserved Mobile Number, length: 1-25, Format: ANS, M/O/C: O,  Description:
        public string reservedMobileNo { get; set; }

        //deviceType, length: 1-20, Format: ANS, M/O/C: O,  Description:
        public string deviceType { get; set; }

        //deviceScore, length: 1, Format: N, M/O/C: O,  Description:
        public string deviceScore { get; set; }
    }
}
