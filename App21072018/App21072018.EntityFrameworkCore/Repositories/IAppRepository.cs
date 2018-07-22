using App21072018.Core;

namespace App21072018.EntityFrameworkCore.Repositories
{
    public interface IAppRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity<int>
    {
        IUnitOfWork UnitOfWork { get; }
    }

    public interface IAppRepository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : class, IEntity<TId>
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
