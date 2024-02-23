using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories
{
    public class RoomImagesRepository : Repository<RoomImages>, IRoomImagesRepository
    {
        public RoomImagesRepository(AppDbContext context) : base(context)
        {

        }
    }
}
