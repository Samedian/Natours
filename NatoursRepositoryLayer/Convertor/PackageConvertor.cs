using AutoMapper;
using NatoursEntities;
using NatoursRepositoryLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NatoursRepositoryLayer.Convertor
{
    public class PackageConvertor : Profile
    {
        public PackageConvertor()
        {
            CreateMap<Package, PackageEntity>().ReverseMap();

        }
    }
}
