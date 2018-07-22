using System;
using System.Threading.Tasks;

namespace App21072018.Core
{
    public interface IUnitOfWork : IDisposable
    {
        Task CommitAsync();
        void Commit();
    }
}
