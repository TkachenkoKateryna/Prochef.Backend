namespace Prochef.Core.Entities
{
    public class VendorCategory
    {
        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
