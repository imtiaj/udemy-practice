using DLL.RequestResponseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.Models
{
    public class CardEnrollmentModel
    {
        public MsginfoModel msgInfo { get; set; }
        public TrxinfoModel trxInfo { get; set; }
        public MsgResponseModel msgResponse { get; set; }
    }  
}
