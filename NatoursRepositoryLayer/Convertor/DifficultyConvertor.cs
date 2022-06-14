using AutoMapper;
using NatoursEntities;
using NatoursRepositoryLayer.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace NatoursRepositoryLayer.Convertor
{
    public class DifficultyConvertor: Profile
    {
        public DifficultyConvertor()
        {
            CreateMap<Difficulty, DifficultyEntity>().ReverseMap();
        }
    }
}
