using NatoursEntities;
using NatoursRepositoryLayer;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NatoursServiceLayer
{
    public class PackageServiceLayer :IPackageServiceLayer
    {
        private readonly IPackageDataLayer _packageLayer;
        public PackageServiceLayer(IPackageDataLayer packageDataLayer)
        {
            _packageLayer = packageDataLayer;
        }

        public async Task<bool> UpdatePackage(PackageEntity packageEntity)
        {
            bool result = await _packageLayer.UpdatePackage(packageEntity);
            return result;
        }

        public async Task<List<PackageEntity>> GetPackage()
        {
            List<PackageEntity> packageEntities = await _packageLayer.GetPackage();
            return packageEntities;
        }
    }
}
