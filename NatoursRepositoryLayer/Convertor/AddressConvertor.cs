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
            // To convert one type into another
            CreateMap<Address, AddressEntity>().ReverseMap();
        }
    }
}
