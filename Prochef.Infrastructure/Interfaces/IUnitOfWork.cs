using Prochef.Infrastructure.Entities.Base;

namespace Prochef.Infrastructure.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class, IBaseEntity;
        void Save();
    }
}
