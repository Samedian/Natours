using NatoursEntities;
using NatoursRepositoryLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace NatoursServiceLayer
{
    public class PackageServiceLayer :IPackageServiceLayer
    {
        private readonly IPackageDataLayer _packageLayer;
        private readonly IBookingDataAccessLayer _bookingDataAccessLayer;
        public PackageServiceLayer(IPackageDataLayer packageDataLayer, IBookingDataAccessLayer bookingDataAccessLayer)
        {
            _packageLayer = packageDataLayer;
            _bookingDataAccessLayer = bookingDataAccessLayer;
        }

        public async Task<bool> UpdatePackage(PackageEntity packageEntity)
        {
            bool result = await _packageLayer.UpdatePackage(packageEntity);
            return result;
        }

        public async Task<List<PackageEntity>> GetPackage()
        {
            List<PackageEntity> packageEntities = await _packageLayer.GetPackage();
            if(packageEntities != null)
            {
                List<BookingEntity> bookingEntity = await _bookingDataAccessLayer.GetAllBookingDetails();
                
                // To fetch how many people booked each package
                foreach (var item in packageEntities)
                {
                    var peopleBooked = bookingEntity.FindAll(n => n.PackageId == item.PackageId && (n.StatusId == (int)Constants.StatusConstant.InProgress || n.StatusId == (int)Constants.StatusConstant.Approved));
                    item.PeopleBooked = peopleBooked.Sum(x => x.NumberOfPeople);
                }
            }
            return packageEntities;
        }
    }
}
