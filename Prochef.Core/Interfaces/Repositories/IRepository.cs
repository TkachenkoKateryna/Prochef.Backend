using Prochef.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Query;

namespace Prochef.Core.Interfaces.Repositories
{
    public interface IRepository<TEntity> where TEntity : class, IBaseEntity
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void SoftDelete(int id);

        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> predicate,
                               Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null);

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate,
                                  Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null);

        IEnumerable<TEntity> FindWithDeleted(Expression<Func<TEntity, bool>> predicate,
                                             Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null);

        public IEnumerable<TEntity> GetAll(Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null);
    }
}
