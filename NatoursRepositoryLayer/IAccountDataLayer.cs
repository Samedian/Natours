using NatoursEntities;
using System.Threading.Tasks;

namespace NatoursRepositoryLayer
{
    public interface IAccountDataLayer
    {
        Task<CustomerEntity> Register(CustomerEntity entity);
        Task<CustomerEntity> Login(CustomerEntity entity);
    }
}