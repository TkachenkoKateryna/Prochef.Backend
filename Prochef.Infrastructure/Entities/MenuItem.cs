using Prochef.Infrastructure.Entities.Base;
using System.Collections.Generic;

namespace Prochef.Infrastructure.Entities
{
    public class MenuItem : BaseEntity
    {
        public MenuItem()
        {
            Ingredients = new List<Ingredient>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public int SectionId { get; set; }
        public MenuSection Section { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
