using System;
using System.Collections.Generic;
using System.Text;

namespace DLL.RequestResponseModel
{
    public class MsginfoModel
    {
        public string versionNo { get; set; }
        public string msgID { get; set; }
        public string timeStamp { get; set; }
        public string msgType { get; set; }
        public string insID { get; set; }
    }
}
