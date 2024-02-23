using DomainLayer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Interfaces
{
    public interface IHouseRepository : IRepository<House>
    {
        Task<List<House>> GetAllHouseAsync();
    }
}
