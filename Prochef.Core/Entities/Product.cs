using System;
using Prochef.Core.Entities.Base;
using System.Collections.Generic;
using Prochef.Core.Constants;

namespace Prochef.Core.Entities
{
    public class Product : BaseEntity
    {
        public Product()
        {
            Ingredients = new List<Ingredient>();
        }

        public string Name { get; set; }
        public double QuantityInStock { get; set; }
        public double Price { get; set; }
        public State State { get; set; }
        public double TermOfUse { get; set; }
        public double Calories { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int PlaceId { get; set; }
        public Place Place { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
