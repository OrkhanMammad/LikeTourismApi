using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    public class HouseRepository : Repository<House>, IHouseRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<House> entities;
        public HouseRepository(AppDbContext context) : base(context)
        {
            _context = context;
            entities = _context.Set<House>();
        }

        public async Task<List<House>> GetAllHouseAsync()
        {
            return await entities.Include(m => m.FamousCity).ToListAsync();

        }
    }
}
