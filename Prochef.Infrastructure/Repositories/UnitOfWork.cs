
using Prochef.Infrastructure.EF;
using Prochef.Core.Entities.Base;
using Prochef.Core.Interfaces.Repositories;
using System.Collections;

namespace Prochef.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProchefDbContext _context;
        private readonly Hashtable _repositories = new Hashtable();

        public UnitOfWork(ProchefDbContext context)
        {
            _context = context;
        }

        public IRepository<TEntity> GetRepository<TEntity>()
            where TEntity : class, IBaseEntity
        {
            var entityTypeName = typeof(TEntity).Name;

            if (!_repositories.ContainsKey(entityTypeName))
            {
                _repositories.Add(entityTypeName, new Repository<TEntity>(_context));
            }

            return (IRepository<TEntity>)_repositories[entityTypeName];
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
