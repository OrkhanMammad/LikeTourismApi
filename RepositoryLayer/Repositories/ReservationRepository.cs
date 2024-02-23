using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    public class ReservationRepository : Repository<Reservation>, IReservationRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Reservation> entities;

        public ReservationRepository(AppDbContext context) : base(context)
        {
            _context = context;
            entities = _context.Set<Reservation>();

        }
        public async Task<Reservation> GetReservationAsync(int id)
        {
            var entity = await entities.Include(m => m.RoomImages).FirstOrDefaultAsync(m => m.Id == id);
            if (entity is null) throw new NullReferenceException();
            return entity;
        }
    }
}
