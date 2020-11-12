using Prochef.Infrastructure.Entities.Base;
using System.Collections.Generic;

namespace Prochef.Infrastructure.Entities
{
    public class Restaurant : BaseEntity
    {
        public Restaurant()
        {
            RestaurantMenus = new List<RestaurantMenu>();
            Employees = new List<Employee>();
        }

        public string Name { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }

        public int? ChainId { get; set; }
        public Chain Chain { get; set; }
        public ICollection<RestaurantMenu> RestaurantMenus { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
