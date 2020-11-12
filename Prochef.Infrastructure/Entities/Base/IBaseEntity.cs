namespace Prochef.Infrastructure.Entities.Base
{
    public interface IBaseEntity
    {
        int Id { get; set; }
        bool IsDeleted { get; set; }
    }
}
