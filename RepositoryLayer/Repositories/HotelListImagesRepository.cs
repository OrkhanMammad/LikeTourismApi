using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories
{
    public class HotelListImagesRepository : Repository<HotelListImages>, IHotelListImagesRepository
    {
        public HotelListImagesRepository(AppDbContext context) : base(context)
        {

        }
    }
}
