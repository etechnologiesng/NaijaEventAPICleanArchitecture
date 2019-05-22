using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NaijaEvent.Application.Common
{
    public class RequestResult
    {

        public bool Successful { get; set; }

        public Exception Exception { get; set; }

        public static async Task< RequestResult> Success()
        {
            return new RequestResult { Successful = true };
        }  

        public static RequestResult Error(Exception exception)
        {
            return new RequestResult { Successful = false, Exception = exception };
        }
    }
}
