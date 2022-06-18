using System;

namespace NatoursExceptions
{
    public class PackageAlreadyBooked : Exception
    {
        public PackageAlreadyBooked(string msg):base(msg)
        {
                
        }
    }
}
