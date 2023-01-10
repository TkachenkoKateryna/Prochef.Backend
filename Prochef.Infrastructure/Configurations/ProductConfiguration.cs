
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prochef.Core.Constants;
using Prochef.Core.Entities;

namespace Prochef.Infrastructure.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            {
                builder.HasQueryFilter(p => !p.IsDeleted);

                builder.HasOne(p => p.Category)
                       .WithMany(c => c.Products)
                       .HasForeignKey(p => p.CategoryId)
                       .OnDelete(DeleteBehavior.Restrict);

                builder.HasOne(p => p.Place)
                       .WithMany(pl => pl.Products)
                       .HasForeignKey(p => p.PlaceId)
                       .OnDelete(DeleteBehavior.Restrict);

                builder.HasData(
                    new Product {Id = 1, Name = "Potato", State = State.Fresh, TermOfUse = 90, Calories = 400, QuantityInStock = 10, PlaceId = 2, CategoryId = 1, DeliveryDate = new DateTime(2020,11,26)},
                    new Product { Id = 2, Name = "Oil", State = State.Fresh, TermOfUse = 720, Calories = 800, QuantityInStock = 15, PlaceId = 3, CategoryId = 7, DeliveryDate = new DateTime(2020, 11, 26) },
                    new Product { Id = 3, Name = "Chicken", State = State.Fresh, TermOfUse = 3, Calories = 120, QuantityInStock = 5, PlaceId = 1, CategoryId = 4, DeliveryDate = new DateTime(2020, 11, 26) },
                    new Product { Id = 4, Name = "Ham", State = State.Fresh, TermOfUse = 14, Calories = 180, QuantityInStock = 3, PlaceId = 1, CategoryId = 4, DeliveryDate = new DateTime(2020, 11, 26) },
                    new Product { Id = 5, Name = "Beef", State = State.Fresh, TermOfUse = 3, Calories = 200, QuantityInStock = 3, PlaceId = 1, CategoryId = 4, DeliveryDate = new DateTime(2020, 11, 26) },
                    new Product { Id = 6, Name = "Flour", State = State.Fresh, TermOfUse = 360, Calories = 350, QuantityInStock = 5, PlaceId = 3, CategoryId = 7, DeliveryDate = new DateTime(2020, 11, 26) },
                    new Product { Id = 8, Name = "Milk", State = State.Fresh, TermOfUse = 7, Calories = 50, QuantityInStock = 6, PlaceId = 1, CategoryId = 3, DeliveryDate = new DateTime(2020, 11, 26) },
                    new Product { Id = 9, Name = "Cheese", State = State.Fresh, TermOfUse = 45, Calories = 360, QuantityInStock = 3, PlaceId = 1, CategoryId = 3, DeliveryDate = new DateTime(2020, 11, 26) },
                    new Product { Id = 10, Name = "Cucumber", State = State.Fresh, TermOfUse = 14, Calories = 30, QuantityInStock = 6, PlaceId = 2, CategoryId = 1, DeliveryDate = new DateTime(2020, 11, 26) },
                    new Product { Id = 11, Name = "Tomato", State = State.Fresh, TermOfUse = 14, Calories = 60, QuantityInStock = 6, PlaceId = 2, CategoryId = 1, DeliveryDate = new DateTime(2020, 11, 26) },
                    new Product { Id = 12, Name = "Ice-cream", State = State.Fresh, TermOfUse = 180, Calories = 500, QuantityInStock = 10, PlaceId = 3, CategoryId = 3, DeliveryDate = new DateTime(2020, 11, 26) },
                    new Product { Id = 13, Name = "Chocolate", State = State.Fresh, TermOfUse = 360, Calories = 600, QuantityInStock = 5, PlaceId = 3, CategoryId = 7, DeliveryDate = new DateTime(2020, 11, 26) },
                    new Product { Id = 14, Name = "Eggs", State = State.Fresh, TermOfUse = 30, Calories = 80, QuantityInStock = 40, PlaceId = 1, CategoryId = 5, DeliveryDate = new DateTime(2020, 11, 26) },
                    new Product { Id = 15, Name = "Salmon", State = State.Fresh, TermOfUse = 3, Calories = 150, QuantityInStock = 4, PlaceId = 1, CategoryId = 6, DeliveryDate = new DateTime(2020, 11, 26) }
                );
            }
        }
    }
}
