using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    public class HotelDescriptionRepository : Repository<HotelDescription>, IHotelDescriptionRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<HotelDescription> entities;

        public HotelDescriptionRepository(AppDbContext context) : base(context)
        {
            _context = context;
            entities = _context.Set<HotelDescription>();
        }

        public async Task<HotelDescription> GetDescAsync(int id)
        {
            var entity = await entities.Where(m => m.SoftDelete == false).FirstOrDefaultAsync(m => m.Id == id);


            if (entity is null) throw new NullReferenceException();
            return entity;
        }
    }
}
