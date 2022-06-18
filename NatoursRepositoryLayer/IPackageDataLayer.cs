using NatoursEntities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NatoursRepositoryLayer
{
    public interface IPackageDataLayer
    {
        Task<bool> UpdatePackage(PackageEntity packageEntity);
        Task<List<PackageEntity>> GetPackage();
    }
}