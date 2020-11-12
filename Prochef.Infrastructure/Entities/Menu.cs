using Prochef.Infrastructure.Entities.Base;
using System.Collections.Generic;

namespace Prochef.Infrastructure.Entities
{
    public class Menu : BaseEntity
    {
        public Menu()
        {
            RestaurantMenus = new List<RestaurantMenu>();
            Sections = new List<MenuSection>();
        }

        public string Title { get; set; }

        public ICollection<RestaurantMenu> RestaurantMenus { get; set; }
        public ICollection<MenuSection> Sections { get; set; }
    }
}
