using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace App21072018.Core
{
    public interface IRepository<TEntity, TId> where TEntity : class, IEntity<TId>
    {
        IQueryable<TEntity> GetQuery();
        Task<TEntity> GetByIdAsync(TId id);
        Task<TEntity> InsertAsync(TEntity entity);
        TEntity Update(TEntity entity, List<Expression<Func<TEntity, object>>> updateProperties = null, List<Expression<Func<TEntity, object>>> excludeProperties = null);
        void Delete(TEntity entity);
    }
    public interface IRepository<TEntity> : IRepository<TEntity, int> where TEntity : class, IEntity<int>
    {
    }
}
