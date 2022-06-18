﻿using AutoMapper;
using NatoursEntities;
using NatoursRepositoryLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using NatoursExceptions;
using System.Security.Cryptography;

namespace NatoursRepositoryLayer
{
    public class AccountDataLayer :IAccountDataLayer
    {
        private readonly NatoursDbContext _dbcontext;
        private readonly IMapper _mapper;
        public AccountDataLayer(NatoursDbContext dbcontext, IMapper mapper)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
        }
        public async Task<CustomerEntity> Register(CustomerEntity entity)
        {
            try
            {
                Customer customer = _dbcontext.customers.FirstOrDefault(x => x.CustomerUserName == entity.CustomerUserName);

                if (customer != null)
                    throw new UserAlreadyExist("User Already Exist");
                var data = _mapper.Map<Customer>(entity);

                //Password
                var hmac = new HMACSHA512();
                data.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(entity.Password));
                data.PasswordSalt = hmac.Key;

                await _dbcontext.customers.AddAsync(data);
                await _dbcontext.SaveChangesAsync();

                var result = _mapper.Map<CustomerEntity>(data);
                result.Password = null;
                result.PasswordHash = null;
                result.PasswordSalt = null;
                return result;

            }
            catch (UserAlreadyExist ex)
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<CustomerEntity> Login(CustomerEntity entity)
        {
            try
            {
                Customer customer = _dbcontext.customers.FirstOrDefault(x => x.CustomerUserName == entity.CustomerUserName);

                if (customer == null)
                    throw new UserNotFound("User Not Found");
                var data = _mapper.Map<Customer>(entity);

                //Password
                var hmac = new HMACSHA512(data.PasswordSalt);

                var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(entity.Password));

                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != data.PasswordHash[i])
                    {
                        throw new UnAuthorized("Inavlid Password");
                    }
                }

                var result = _mapper.Map<CustomerEntity>(data);
                result.Password = null;
                result.PasswordHash = null;
                result.PasswordSalt = null;
                return result;

            }
            catch (UserNotFound ex)
            {
                return null;
            }
            catch (UnAuthorized ex)
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}