using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using NatoursEntities;
using NatoursRepositoryLayer.Model;

namespace NatoursRepositoryLayer.Convertor
{
    public class BookingConvertor :Profile
    {
        public BookingConvertor()
        {
            CreateMap<Booking, BookingEntity>().ReverseMap();
        }        

        internal T2 Map<T1, T2>(T1 getAllBookingDetails)
        {
            throw new NotImplementedException();
        }
    }
}
