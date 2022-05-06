using HumanResources.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Domain.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepo<T> GetRepository<T>() where T : class;
        Task<int> SaveChangeAsync();
        int SaveChange();
    }
}
