using System;

namespace Prochef.Core.Dtos.Response
{
    public class ProductResponse
    {
        public string Name { get; set; }
        public double QuantityInStock { get; set; }
        public double Price { get; set; }
        public string State { get; set; }
        public double TermOfUse { get; set; }
        public double Calories { get; set; }
        public DateTime DeliveryDate { get; set; }
        public string Place { get; set; }
        public string Category { get; set; }
        public bool IsDeleted { get; set; }
    }
}
