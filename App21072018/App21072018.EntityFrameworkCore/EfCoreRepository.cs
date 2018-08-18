using App21072018.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public TEntity Update(TEntity entity, List<Expression<Func<TEntity, object>>> updateProperties = null, List<Expression<Func<TEntity, object>>> excludeProperties = null)
        {
            _dbSet.Attach(entity);

            if (updateProperties == null || updateProperties.Count == 0)
            {
                _dbContext.Entry<TEntity>(entity).State = EntityState.Modified;
                if (excludeProperties != null && excludeProperties.Count > 0)
                {
                    excludeProperties.ForEach(p => _dbContext.Entry<TEntity>(entity).Property(p).IsModified = false);
                }
            }
            else
            {
                updateProperties.ForEach(p => _dbContext.Entry<TEntity>(entity).Property(p).IsModified = true);
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
