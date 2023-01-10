using Prochef.Core.Entities.Base;
using System.Collections.Generic;
using System.Linq;
using Prochef.Core.Constants;

namespace Prochef.Core.Entities
{
    public class MenuItem : BaseEntity
    {
        public MenuItem()
        {
            Ingredients = new List<Ingredient>();
            Price = GetFullPrice();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool Show { get; set; }
        public TimeOfTheDay TimeOfTheDay { get; set; }
        public int SectionId { get; set; }
        public MenuSection Section { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }

        public double GetFullPrice()
        {
            return Ingredients.Sum(x => x.GetPrice());
        }
    }
}
