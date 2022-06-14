using AutoMapper;
using NatoursEntities;
using NatoursRepositoryLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NatoursRepositoryLayer.Convertor
{
    public class AddressConvertor : Profile
    {
        public AddressConvertor()
        {
            CreateMap<Address, AddressEntity>().ReverseMap();

        }
    }
}
