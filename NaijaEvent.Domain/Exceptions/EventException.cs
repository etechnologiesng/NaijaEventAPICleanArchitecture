using System;
using System.Collections.Generic;
using System.Text;

namespace NaijaEvent.Domain.Exceptions
{
    class InvalidEventNameException : Exception
    {

        public InvalidEventNameException()
        {

        }
        public InvalidEventNameException(string name)
            : base(String.Format("Invalid Student Name: {0}", name))
        {

        }
    }
}
