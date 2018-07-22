using App21072018.Core;

namespace App21072018.EntityFrameworkCore.Repositories
{

    public class AppRepository<TEntity> :
         EfCoreRepository<App21072018DbContext, TEntity, int>,
         IAppRepository<TEntity> where TEntity : class, IEntity<int>
    {
        private readonly App21072018DbContext _db;

        public AppRepository(App21072018DbContext db) : base(db)
        {
            _db = db;
        }

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _db;
            }
        }
    }

    public class AppRepository<TEntity, TId> :
        EfCoreRepository<App21072018DbContext, TEntity, TId>,
        IAppRepository<TEntity, TId> where TEntity : class, IEntity<TId>
    {
        private readonly App21072018DbContext _db;

        public AppRepository(App21072018DbContext db) : base(db)
        {
            _db = db;
        }

        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _db;
            }
        }
    }
}
