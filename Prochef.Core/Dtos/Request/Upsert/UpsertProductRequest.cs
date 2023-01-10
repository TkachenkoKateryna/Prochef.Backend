
using System;
using Prochef.Core.Entities;

namespace Prochef.Core.Dtos.Request.Products
{
    public class UpsertProductRequest
    {
        public string Name { get; set; }
        public double QuantityInStock { get; set; }
        public double Price { get; set; }
        public int State { get; set; }
        public double TermOfUse { get; set; }
        public double Calories { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int PlaceId { get; set; }
        public int CategoryId { get; set; }
    }            
}
