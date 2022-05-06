using HumanResources.Domain.Repositories;
using HumanResources.Domain.UnitOfWork;
using HumanResources.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _db;

        public UnitOfWork(AppDbContext db)
        {
            _db = db;
        }

        private bool _disposed = false;

        private void Disposed(bool disposed)
        {
            if (!this._disposed)
            {
                if (disposed)
                {
                    _db.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Disposed(true);
            GC.SuppressFinalize(this);
        }

        public IBaseRepo<T> GetRepository<T>() where T : class
        {
            return new BaseRepository<T>(_db);
        }

        public int SaveChange()
        {
            return _db.SaveChanges();
        }

        public async Task<int> SaveChangeAsync()
        {
            return await _db.SaveChangesAsync();
        }
    }
}
