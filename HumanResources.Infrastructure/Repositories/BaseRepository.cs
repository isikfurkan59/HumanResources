using HumanResources.Domain.Enums;
using HumanResources.Domain.Interfaces;
using HumanResources.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepo<T> where T : class
    {
        private readonly AppDbContext _db;
        protected DbSet<T> _ds;

        public BaseRepository(AppDbContext db)
        {
            _db = db;
            _ds = _db.Set<T>();
        }

        public async Task<bool> Any(Expression<Func<T, bool>> expression)
        {
            return await _ds.AnyAsync(expression);
        }

        public async Task Create(T entity)
        {
            await _ds.AddAsync(entity);
        }

        public virtual void Delete(T entity)
        {
            if (entity.GetType().GetProperty("State") != null)
            {
                entity.GetType().GetProperty("State").SetValue(entity, State.Passive);
                this.Update(entity);
            }
            else
            {
                EntityEntry entityEntry = _db.Entry<T>(entity);
                if (entityEntry.State != EntityState.Deleted)
                {
                    entityEntry.State = EntityState.Deleted;
                }
                else
                {
                    _ds.Attach(entity);
                    _ds.Remove(entity);
                }
            }
        }

        public async Task<IEnumerable<TResult>> GetFilteredList<TResult>(Expression<Func<T, TResult>> select, 
            Expression<Func<T, bool>> where, 
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, 
            Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = _ds;

            if (where != null) query = query.Where(where);

            if (include != null) query = include(query);

            if (orderBy != null) return await orderBy(query).Select(select).ToListAsync();

            else return await query.Select(select).ToListAsync();
        }

        public async Task<T> GetFirstOrDefault(Expression<Func<T, bool>> expression)
        {
            return await _ds.FirstOrDefaultAsync(expression);
        }

        public async Task<TResult> GetFirstOrDefault<TResult>(Expression<Func<T, TResult>> select, 
            Expression<Func<T, bool>> where, Func<IQueryable<T>, 
                IIncludableQueryable<T, object>> include = null, 
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
        {
            IQueryable<T> query = _ds;

            if (where != null) query = query.Where(where);

            if (include != null) query = include(query);

            if (orderBy != null) return await orderBy(query).Select(select).FirstOrDefaultAsync();

            else return await query.Select(select).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<T>> GetList(Expression<Func<T, bool>> expression)
        {
            return await _ds.Where(expression).ToListAsync();
        }

        public void Update(T entity)
        {
            _db.Attach(entity);
            _db.Entry<T>(entity).State = EntityState.Modified;
        }
    }
}
