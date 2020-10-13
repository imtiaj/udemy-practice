using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Text;

namespace DLL.RequestResponseModel
{
    public class CvmAddTLDocmModel
    {
        /*
         * Data Type, length 1-256, fromat ANS, Mandatory
         * ex: Valid Values "IDcard","Passport","selfPhoto" 
         */
        public string dataType { get; set; }

        /*
         * Data Type, length 1-20, fromat ANS, Mandatory
         * ex: Valid Values "PNG","JPG","DOC","PDF" 
         */
        public string dataFormat { get; set; }

        /*
         * Data Note, length 1-120, fromat S, Optional
         * ex: Valid Values "PNG","JPG","DOC","PDF" 
         */
        public string dataNote { get; set; }

        /*
         * Data Content, length 1-2048000, fromat ANS, Mandatory
         * Data of file in Base64 format
         */
        public string dataContent { get; set; }
    }
}
