using Prochef.Infrastructure.Entities.Base;

namespace Prochef.Infrastructure.Entities
{
    public class Ingredient : BaseEntity
    {
        public int MenuItemId { get; set; }
        public MenuItem MenuItem { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        public double Weight { get; set; }
    }
}
