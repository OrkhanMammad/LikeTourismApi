using DomainLayer.Entities;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories.Interfaces
{
    public interface IHotelDescriptionRepository : IRepository<HotelDescription>
    {
        Task<HotelDescription> GetDescAsync(int id);




    }
}
