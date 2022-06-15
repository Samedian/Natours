using NatoursEntities;
using NatoursRepositoryLayer.Convertor;
using NatoursRepositoryLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NatoursRepositoryLayer
{
    public class BookingDataAccessLayer : IBookingDataAccessLayer
    {
        private readonly NatoursDbContext _dbcontext;
        private readonly BookingConvertor _bookingConvertor;
        public BookingDataAccessLayer(NatoursDbContext dbcontext, BookingConvertor bookingConvertor)
        {
            _dbcontext = dbcontext;
            _bookingConvertor = bookingConvertor;
        }
        public List<BookingEntity> GetAllBookingDetails()
        {
            List<Booking> getAllBookingDetails = _dbcontext.bookings.ToList<Booking>();
            return _bookingConvertor.Map<List<Booking>, List<BookingEntity>>(getAllBookingDetails);
        }
    }
}
