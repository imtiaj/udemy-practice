using System;
namespace DLL.RequestResponseModel
{
    public class UPIBaseResponseGenerics<T> where T : class
    {
        public MsginfoModel msgInfo { get; set; }

        public T trxInfo { get; set; }

        public MsgResponseModel msgResponse { get; set; }
    }
}
