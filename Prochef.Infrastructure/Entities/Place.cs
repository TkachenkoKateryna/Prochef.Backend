using Prochef.Infrastructure.Entities.Base;
using System.Collections.Generic;

namespace Prochef.Infrastructure.Entities
{
    public class Place : BaseEntity
    {
        public Place()
        {
            Products = new List<Product>();
        }

        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
