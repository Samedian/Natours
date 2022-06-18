using System;
using System.Collections.Generic;
using System.Text;

namespace NatoursExceptions
{
    public class UnAuthorized : Exception
    {
        public UnAuthorized(string msg):base(msg)
        {
                
        }
    }
}
