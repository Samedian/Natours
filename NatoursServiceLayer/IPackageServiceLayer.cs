using NatoursEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NatoursServiceLayer
{
    public interface IPackageServiceLayer
    {
        Task<bool> UpdatePackage(PackageEntity packageEntity);
        Task<List<PackageEntity>> GetPackage();
    }
}
