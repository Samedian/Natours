using NatoursEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NatoursRepositoryLayer
{
    public interface IBookingDataAccessLayer
    {
        List<BookingEntity> GetAllBookingDetails();
    }
}
