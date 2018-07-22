using System.Linq;
using System.Threading.Tasks;

namespace App21072018.Core
{
    public interface IRepository<TEntity, TId> where TEntity : class, IEntity<TId>
    {
        IQueryable<TEntity> GetQuery();
        Task<TEntity> GetByIdAsync(TId id);
        Task<TEntity> InsertAsync(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
    }
    public interface IRepository<TEntity> : IRepository<TEntity, int> where TEntity : class, IEntity<int>
    {
    }
}
