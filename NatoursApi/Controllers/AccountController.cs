using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using NatoursEntities;
using NatoursServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NatoursApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAuthenticateService _authenticationService;
        public AccountController(IAuthenticateService authenticationService)
        {
            this._authenticationService = authenticationService;
        }


        /// <summary>
        /// This is used to Login 
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost("Login")]
        public async Task<CustomerEntity> Login(CustomerEntity customer)
        {
            CustomerEntity user = await _authenticationService.Login(customer);
            return user;
        }

        [HttpPost("Register")]
        public async Task<CustomerEntity> Register(CustomerEntity customer)
        {

            CustomerEntity user = await _authenticationService.Register(customer);
            return user;
        }
    }
}
