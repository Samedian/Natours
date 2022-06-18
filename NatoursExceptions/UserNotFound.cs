using System;
using System.Collections.Generic;
using System.Text;

namespace NatoursExceptions
{
    public class UserNotFound : Exception
    {
        public UserNotFound(string msg):base(msg)
        {

        }
    }
}
