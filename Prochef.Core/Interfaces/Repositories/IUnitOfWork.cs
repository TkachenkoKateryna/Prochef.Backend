using Prochef.Core.Entities.Base;

namespace Prochef.Core.Interfaces.Repositories
{
    public interface IUnitOfWork
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class, IBaseEntity;
        void Save();
    }
}
