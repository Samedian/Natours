using System;
using System.Collections.Generic;
using System.Text;

namespace NatoursExceptions
{
    public class PackageNotFound : Exception
    {
        public PackageNotFound(string msg):base(msg)
        {

        }
    }
}
