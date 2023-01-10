using Prochef.Core.Entities.Base;
using System.Collections.Generic;

namespace Prochef.Core.Entities
{
    public class Menu : BaseEntity
    {
        public Menu()
        {
            Sections = new List<MenuSection>();
            Restaurants = new List<Restaurant>();
        }

        public string Title { get; set; }

        public ICollection<MenuSection> Sections { get; set; }
        public ICollection<Restaurant> Restaurants { get; set; }
    }
}
