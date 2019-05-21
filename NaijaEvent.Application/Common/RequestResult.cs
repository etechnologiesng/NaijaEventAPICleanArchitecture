using System;
using System.Collections.Generic;
using System.Text;

namespace NaijaEvent.Application.Common
{
    class RequestResult
    {

        public bool Successful { get; set; }

        public Exception Exception { get; set; }

        public static RequestResult Success()
        {
            return new RequestResult { Successful = true };
        }  

        public static RequestResult Error(Exception exception)
        {
            return new RequestResult { Successful = false, Exception = exception };
        }
    }
}
