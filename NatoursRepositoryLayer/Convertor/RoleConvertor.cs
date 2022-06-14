using AutoMapper;
using NatoursEntities;
using NatoursRepositoryLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NatoursRepositoryLayer.Convertor
{
    public class RoleConvertor : Profile
    {
        public RoleConvertor()
        {
            CreateMap<Role, RoleEntity>().ReverseMap();

        }
    }
}
