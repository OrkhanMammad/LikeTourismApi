using DomainLayer.Entities;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Interfaces
{
    public interface IHotelListRepository : IRepository<HotelList>
    {
        Task<HotelList> GetHotelListAsync(int id);
        Task<HotelList> GetHotelsListAsync(int id);






    }
}
