using DomainLayer.Entities;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories
{
    public class FamousCityRepository : Repository<FamousCity>, IFamousCityRepository
    {
        public FamousCityRepository(AppDbContext context) : base(context)
        {

        }
    }
}
