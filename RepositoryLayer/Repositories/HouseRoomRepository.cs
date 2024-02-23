using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    public class HouseRoomRepository : Repository<HouseRoom>, IHouseRoomRepository
    {

        private readonly AppDbContext _context;
        private readonly DbSet<HouseRoom> entities;
        public HouseRoomRepository(AppDbContext context) : base(context)
        {
            _context = context;
            entities = _context.Set<HouseRoom>();
        }

        public Task<Reservation> GetReservationAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
