using NatoursEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NatoursServiceLayer
{
    public interface IAuthenticateService
    {
        Task<CustomerEntity> Login(CustomerEntity entity);
        Task<CustomerEntity> Register(CustomerEntity entity);
    }
}
