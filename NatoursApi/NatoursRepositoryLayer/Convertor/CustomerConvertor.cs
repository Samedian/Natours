using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using NatoursEntities;
using NatoursRepositoryLayer.Model;

namespace NatoursRepositoryLayer.Convertor
{
    public class CustomerConvertor: Profile
    {
        public CustomerConvertor()
        {
            CreateMap<Customer, CustomerEntity>().ReverseMap();

        }
    }
}
