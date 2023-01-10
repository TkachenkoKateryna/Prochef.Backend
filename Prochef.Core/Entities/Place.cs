using Prochef.Core.Entities.Base;
using System.Collections.Generic;

namespace Prochef.Core.Entities
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
