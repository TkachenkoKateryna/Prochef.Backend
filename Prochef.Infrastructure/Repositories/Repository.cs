

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Prochef.Infrastructure.EF;
using Prochef.Core.Entities.Base;
using Prochef.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Prochef.Infrastructure.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IBaseEntity
    {
        protected readonly ProchefDbContext DbContext;
        protected readonly DbSet<TEntity> DbSet;
        protected IQueryable<TEntity> QueryableDbSet;

        public Repository(ProchefDbContext context)
        {
            DbContext = context;
            DbSet = DbContext.Set<TEntity>();
            QueryableDbSet = DbSet;
        }

        public void Create(TEntity entity)
        {
            DbSet.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            DbSet.Remove(entity);
        }

        public void SoftDelete(int id)
        {
            DbSet.Find(id).IsDeleted = true;
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate,
                                      Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null)
        {
            if (include != null)
            {
                QueryableDbSet = include(QueryableDbSet);
            }

            return QueryableDbSet.AsNoTracking().FirstOrDefault(predicate);
        }

        public void Update(TEntity entity)
        {
            DbContext.Entry(entity).State = EntityState.Modified;
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate,
                                         Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null)
        {
            if (include != null)
            {
                QueryableDbSet = include(QueryableDbSet);
            }

            return QueryableDbSet.AsNoTracking().Where(predicate);
        }

        public IEnumerable<TEntity> FindWithDeleted(Expression<Func<TEntity, bool>> predicate,
                                                    Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null)
        {
            QueryableDbSet = DbContext.Set<TEntity>().IgnoreQueryFilters();

            if (include != null)
            {
                QueryableDbSet = include(QueryableDbSet);
            }

            return QueryableDbSet.AsNoTracking().Where(predicate);
        }

        public IEnumerable<TEntity> GetAll(Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null)
        {
            if (include != null)
            {
                QueryableDbSet = include(QueryableDbSet);
            }

            return QueryableDbSet.AsNoTracking();
        }

        public IQueryable<TEntity> GetAllIQueryable(Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null)
        {
            if (include != null)
            {
                QueryableDbSet = include(QueryableDbSet);
            }

            return QueryableDbSet.AsNoTracking();
        }

        public IQueryable<TEntity> GetAllQueryable(Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null)
        {
            if (include != null)
            {
                QueryableDbSet = include(QueryableDbSet);
            }

            return QueryableDbSet.AsNoTracking();
        }

        public IEnumerable<TEntity> GetAllWithDeleted(Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null)
        {
            QueryableDbSet = DbContext.Set<TEntity>().IgnoreQueryFilters();

            if (include != null)
            {
                QueryableDbSet = include(QueryableDbSet);
            }

            return QueryableDbSet.AsNoTracking();
        }
    }
}
