using NatoursEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NatoursServiceLayer
{
    public interface IBookingBusinessLayer
    {
        List<BookingEntity> GetAllBookingDetails();
    }
}
