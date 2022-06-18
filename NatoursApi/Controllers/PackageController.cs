using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NatoursEntities;
using NatoursServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NatoursApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackageController : ControllerBase
    {
        private readonly IPackageServiceLayer _packageServiceLayer;
        public PackageController(IPackageServiceLayer packageServiceLayer)
        {
            _packageServiceLayer = packageServiceLayer;
        }

        [HttpGet("GetAllPackages")]
        public async Task<List<PackageEntity>> GetAllPackages()
        {
            List<PackageEntity> packageEntities = await _packageServiceLayer.GetPackage();
            return packageEntities;
        }

        [Authorize(Roles = "Admin")]
        [HttpPost("Update")]
        public async Task<bool> UpdatePackage(PackageEntity entity)
        {
            bool result = await _packageServiceLayer.UpdatePackage(entity);
            return result;
        }

    }
}
