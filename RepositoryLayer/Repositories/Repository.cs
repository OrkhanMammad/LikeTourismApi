using DomainLayer.Common;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RepositoryLayer.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> entities;
        public Repository(AppDbContext context)
        {
            _context = context;
            entities = _context.Set<T>();
        }
        public async Task CreateAsync(T entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));
            await entities.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            if (entity is null) throw new ArgumentNullException();
            entity.SoftDelete = true;
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            IEnumerable<T> datas = await entities.Where(predicate).Where(m => m.SoftDelete == false).ToListAsync();
            return datas;
        }

        public async Task<T> GetAsync(int id)
        {
            T entity = await entities.Where(m => m.SoftDelete == false).FirstOrDefaultAsync(m => m.Id == id);
            if (entity is null) throw new NullReferenceException(nameof(entity));
            return entity;
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await entities.Where(m => m.SoftDelete == false).ToListAsync();
        }

        public async Task SoftDeleteAsync(T entity)
        {
            T entityDb = await entities.FirstOrDefaultAsync(m => m.Id == entity.Id);
            if (entity is null) throw new ArgumentNullException();
            entityDb.SoftDelete = true;
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            if (entity is null) throw new ArgumentNullException(nameof(entity));
            entities.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> predicate)
        {
            IEnumerable<T> datas = await entities.Where(m => m.SoftDelete == false).Where(predicate).ToListAsync();

            return datas;

        }
    }
}
