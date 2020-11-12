using Prochef.Infrastructure.Entities.Base;
using System.Collections.Generic;

namespace Prochef.Infrastructure.Entities
{
    public class Vendor : BaseEntity
    {
        public Vendor()
        {
            VendorCategories = new List<VendorCategory>();
        }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string  Email { get; set; }
        public string Address { get; set; }

        public ICollection<VendorCategory> VendorCategories { get; set; }
    }
}
