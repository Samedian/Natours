using System;
using System.Collections.Generic;
using System.Text;

namespace NatoursExceptions
{
    public class UserAlreadyExist:Exception
    {
        public UserAlreadyExist(string msg):base(msg)
        {

        }
    }
}
