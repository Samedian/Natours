using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using NatoursEntities;
using NatoursRepositoryLayer;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NatoursServiceLayer
{
    /// <summary>
    /// Authentication Service 
    /// </summary>
    public class AuthenticateService : IAuthenticateService
    {
        private readonly AppSetting _appSetting;
        private readonly IAccountDataLayer _accountDataLayer;

        public AuthenticateService(IOptions<AppSetting> appSetting,IAccountDataLayer accountDataLayer)
        {
            _appSetting = appSetting.Value;
            _accountDataLayer = accountDataLayer;
        }
        
        public async Task<CustomerEntity> Login(CustomerEntity entity)
        {
            var data = await _accountDataLayer.Login(entity);
            if (data == null)
            {
                return null;
            }

            GenerateToken(data);

            return data;
        }

        public async Task<CustomerEntity> Register(CustomerEntity entity)
        {
            CustomerEntity customerEntity = await _accountDataLayer.Register(entity);
            if (customerEntity == null)
                return null;

            GenerateToken(customerEntity);
            return customerEntity;

        }

        private void GenerateToken(CustomerEntity entity)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSetting.JwtTokenKey);
            var tokenDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] {
                    new Claim(ClaimTypes.Name, entity.CustomerName),
                    new Claim(ClaimTypes.Role, entity.RoleId==(int)Constants.RolesConstant.Admin?"Admin":"User")
                }),
                Expires = DateTime.UtcNow.AddDays(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescription);
            entity.JwtToken = tokenHandler.WriteToken(token);

        }
    }
}
