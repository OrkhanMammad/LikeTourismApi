using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    public class HotelListRepository : Repository<HotelList>, IHotelListRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<HotelList> entities;

        public HotelListRepository(AppDbContext context) : base(context)
        {
            _context = context;
            entities = _context.Set<HotelList>();

        }
        public async Task<HotelList> GetHotelListAsync(int id)
        {
            var entity = await entities
                .Where(m => m.SoftDelete == false)
                .Include(m => m.HotelListImages)
                .Include(m => m.HotelDescriptions)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (entity.HotelDescriptions[0].SoftDelete == true)
            {
                entity.HotelDescriptions[0] = null;
            }

            if (entity is null) throw new NullReferenceException();
            return entity;
        }

        public async Task<HotelList> GetHotelsListAsync(int id)
        {
            var entity = await entities
                .Where(m => m.SoftDelete == false)
                .Include(m => m.HotelListImages)
                .Include(m => m.HotelDescriptions)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (entity is null) throw new NullReferenceException();
            return entity;
        }
    }
}
