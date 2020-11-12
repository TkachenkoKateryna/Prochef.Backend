namespace Prochef.Infrastructure.Entities.Base
{
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
    }
}
