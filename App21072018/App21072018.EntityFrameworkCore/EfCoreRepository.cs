using App21072018.Core;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace App21072018.EntityFrameworkCore
{
    public class EfCoreRepository<TDbContext, TEntity, TId> :
         IRepository<TEntity, TId>
         where TEntity : class, IEntity<TId>
         where TDbContext : DbContext
    {
        private readonly TDbContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public EfCoreRepository(TDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        public IQueryable<TEntity> GetQuery()
        {
            return _dbSet;
        }

        public async Task<TEntity> GetByIdAsync(TId id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<TEntity> InsertAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            if (entity != null)
            {
                _dbContext.Entry(entity).State = EntityState.Modified;
            }

            return entity;
        }

        public void Delete(TEntity entity)
        {
            if (entity != null)
            {
                _dbSet.Remove(entity);
            }
        }
    }
}
