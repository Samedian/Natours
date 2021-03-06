using NatoursEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NatoursRepositoryLayer
{
    public interface IBookingDataAccessLayer
    {
        Task<List<BookingEntity>> GetAllBookingDetails();
        Task<bool> BookPackageAdd(BookingEntity entity);
        Task<bool> BookPackageUpdate(BookingEntity entity);

    }
}
