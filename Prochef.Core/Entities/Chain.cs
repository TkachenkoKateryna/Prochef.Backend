using Prochef.Core.Entities.Base;
using System.Collections.Generic;

namespace Prochef.Core.Entities
{
    public class Chain : BaseEntity
    {
        public Chain()
        {
            Restaurants = new List<Restaurant>();
        }

        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public ICollection<Restaurant> Restaurants { get; set; }
    }
}
