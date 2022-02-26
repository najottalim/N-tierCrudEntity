using Microsoft.EntityFrameworkCore;
using N_tierCrudEntity.Data.Contexts;
using N_tierCrudEntity.Data.IRepositories;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace N_tierCrudEntity.Data.Repositories
{
#pragma warning disable
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private TestDbContext _db;

        private DbSet<T> _dbSet;
        public GenericRepository()
        {
            _db = new TestDbContext();

            _dbSet = _db.Set<T>();
        }

        public async Task<T> CreateAsync(T entity)
        {
            var entry = await _dbSet.AddAsync(entity);

            await _db.SaveChangesAsync();

            return entry.Entity;
        }

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate)
        {
            var entity = _dbSet.FirstOrDefault(predicate);

            if (entity == null)
                return false;

            _dbSet.Remove(entity);

            await _db.SaveChangesAsync();

            return true;
        }

        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            return predicate == null ? _dbSet : _dbSet.Where(predicate);
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            var updatedEntity = _dbSet.Update(entity);

            await _db.SaveChangesAsync();

            return updatedEntity.Entity;
        }
    }
}
