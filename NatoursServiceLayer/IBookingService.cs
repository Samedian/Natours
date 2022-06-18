using NatoursEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NatoursServiceLayer
{
    public interface IBookingService
    {
        Task<List<BookingEntity>> GetAllBookingDetails();
        Task<bool> BookPackageAdd(BookingEntity entity);
        Task<bool> BookPackageUpdate(BookingEntity entity);
    }
}
