using NatoursEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NatoursServiceLayer
{
    public interface IAuthenticateService
    {
       CustomerEntity authenticate(string user, string password);
    }
}
