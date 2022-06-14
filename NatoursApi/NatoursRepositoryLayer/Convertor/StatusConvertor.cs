using AutoMapper;
using NatoursEntities;
using NatoursRepositoryLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NatoursRepositoryLayer.Convertor
{
    public class StatusConvertor:Profile
    {
        public StatusConvertor()
        {
            CreateMap<Status, StatusEntity>().ReverseMap();

        }
    }
}
