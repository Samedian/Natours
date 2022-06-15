using NatoursEntities;
using NatoursRepositoryLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace NatoursServiceLayer
{
    public class BookingBusinessLayer : IBookingBusinessLayer
    {
        private readonly IBookingDataAccessLayer _dataAccessLayer;

        public BookingBusinessLayer(IBookingDataAccessLayer dataAccessLayer)
        {
            this._dataAccessLayer = dataAccessLayer;
        }
        public List<BookingEntity> GetAllBookingDetails()
        {
            List<BookingEntity> getAllBookingDetails = _dataAccessLayer.GetAllBookingDetails();
            return getAllBookingDetails;
        }
    }
}
