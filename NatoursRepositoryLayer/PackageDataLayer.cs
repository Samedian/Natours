using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NatoursEntities;
using NatoursRepositoryLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatoursRepositoryLayer
{
    public class PackageDataLayer : IPackageDataLayer
    {
        private readonly NatoursDbContext _dbcontext;
        private readonly IMapper _mapper;
        public PackageDataLayer(NatoursDbContext dbcontext, IMapper mapper)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
        }

        /// <summary>
        /// Update Package details to DB
        /// </summary>
        /// <param name="packageEntity"></param>
        /// <returns></returns>
        public async Task<bool> UpdatePackage(PackageEntity packageEntity)
        {
            Package package = _mapper.Map<Package>(packageEntity);
            try
            {
                _dbcontext.Entry(await _dbcontext.packages.FirstOrDefaultAsync(x => x.PackageId == packageEntity.PackageId)).CurrentValues.SetValues(package);
                await _dbcontext.SaveChangesAsync();                

            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// fetch Package List 
        /// </summary>
        /// <returns></returns>
        public async Task<List<PackageEntity>> GetPackage()
        {
            List<PackageEntity> packageEntities = new List<PackageEntity>();
            List<Package> packages = null;

            try
            {
                packages = _dbcontext.packages.ToList();                
            }
            catch (Exception ex)
            {
                return null;
            }

            foreach (var package in packages)
            {
                PackageEntity packageEntity = _mapper.Map<PackageEntity>(package);
                packageEntities.Add(packageEntity);
            }
            return packageEntities;
        }
    }
}

