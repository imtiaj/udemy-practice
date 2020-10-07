using System;
using System.Collections.Generic;
using System.Text;

namespace Utility.Exceptions
{
    public class ApiExceptions : Exception
    {
        public ApiExceptions(string message):base(message)
        {

        }
    }
}
