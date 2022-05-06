using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Domain.Repositories
{
    public interface IBaseRepo<T> where T : class
    {
        Task Create(T entity);
        void Delete(T entity);
        void Update(T entity);

        Task<T> GetFirstOrDefault(Expression<Func<T, bool>> expression);

        Task<IEnumerable<T>> GetList(Expression<Func<T, bool>> expression);

        Task<bool> Any(Expression<Func<T, bool>> expression);

        Task<TResult> GetFirstOrDefault<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null);

        Task<IEnumerable<TResult>> GetFilteredList<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);

    }
}
