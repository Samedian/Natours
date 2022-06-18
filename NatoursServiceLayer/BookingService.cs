using NatoursEntities;
using NatoursRepositoryLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NatoursServiceLayer
{
    public class BookingService : IBookingService
    {
        private readonly IBookingDataAccessLayer _dataAccessLayer;

        public BookingService(IBookingDataAccessLayer dataAccessLayer)
        {
            this._dataAccessLayer = dataAccessLayer;
        }
        public async Task<bool> BookPackageAdd(BookingEntity entity)
        {
            bool result = await _dataAccessLayer.BookPackageAdd(entity);
            return result;
        }

        public async Task<bool> BookPackageUpdate(BookingEntity entity)
        {
            bool result = await _dataAccessLayer.BookPackageUpdate(entity);
            return result;
        }

        public async Task<List<BookingEntity>> GetAllBookingDetails()
        {
            List<BookingEntity> getAllBookingDetails = await _dataAccessLayer.GetAllBookingDetails();
            return getAllBookingDetails;
        }
    }
}
