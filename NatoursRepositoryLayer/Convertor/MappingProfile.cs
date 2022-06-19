using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using NatoursEntities;
using NatoursRepositoryLayer.Model;

namespace NatoursRepositoryLayer.Convertor
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer, CustomerEntity>().ReverseMap();
            CreateMap<Address, AddressEntity>().ReverseMap();
            CreateMap<Role, RoleEntity>().ReverseMap();
            CreateMap<Booking, BookingEntity>().ReverseMap();
            CreateMap<Difficulty, DifficultyEntity>().ReverseMap();
            CreateMap<Package, PackageEntity>().ReverseMap();
            CreateMap<Status, StatusEntity>().ReverseMap();

        }
    }
}
