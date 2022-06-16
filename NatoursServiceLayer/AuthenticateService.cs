using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using NatoursEntities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace NatoursServiceLayer
{
    /// <summary>
    /// Authentication Service 
    /// </summary>
    public class AuthenticateService : IAuthenticateService
    {
        private readonly AppSetting _appSetting;
        public AuthenticateService(IOptions<AppSetting> appSetting)
        {
            _appSetting = appSetting.Value;
        }
        CustomerEntity customer = new CustomerEntity()
        {
            CustomerName = "Nabin",
            PasswordHash = "12345"
        };

        public CustomerEntity authenticate(string user, string password)
        {
            var userName = customer.CustomerName == user && customer.PasswordHash == password;
            if (userName == false)
            {
                return null;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSetting.JwtTokenKey);
            var tokenDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] {
                    new Claim(ClaimTypes.Name, user),
                    new Claim(ClaimTypes.Role, "admin")
                }),
                Expires = DateTime.UtcNow.AddDays(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescription);
            customer.JwtToken = tokenHandler.WriteToken(token);
            customer.PasswordHash = "";
            return customer;
        }
    }
}
