using Prochef.Core.Entities.Base;
using System.Collections.Generic;

namespace Prochef.Core.Entities
{
    public class Category : BaseEntity
    {
        public Category()
        {
            Products = new List<Product>();
            VendorCategories = new List<VendorCategory>();
        }

        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<VendorCategory> VendorCategories { get; set; }
    }
}
