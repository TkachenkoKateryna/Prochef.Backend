
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prochef.Core.Entities;

namespace Prochef.Infrastructure.Configurations
{
    public class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant> 
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder) 
        {
            {
                builder.HasQueryFilter(b => !b.IsDeleted);

                builder.HasOne(p => p.Chain)
                    .WithMany(p => p.Restaurants)
                    .HasForeignKey(p => p.ChainId)
                    .IsRequired(false)
                    .OnDelete(DeleteBehavior.Restrict);

                builder.HasOne(p => p.Menu)
                    .WithMany(p => p.Restaurants)
                    .HasForeignKey(p => p.MenuId)
                    .IsRequired(false)
                    .OnDelete(DeleteBehavior.Restrict);

                builder.HasData(
                    new Restaurant
                    {
                        Id = 1,
                        ChainId = 1,
                        MenuId = 1,
                        Name = "Macdonals",
                        Phone = "+3800996844514",
                        Address = "str. Sumskaya 4"
                    },
                    new Restaurant
                    {
                        Id = 2,
                        ChainId = 1,
                        MenuId = 1,
                        Name = "Macdonals",
                        Phone = "+38009234314",
                        Address = "str. Beketova 4"
                    },
                    new Restaurant
                    {
                        Id = 3,
                        ChainId = 2,
                        MenuId = 2,
                        Name = "KFC",
                        Phone = "+380096523214",
                        Address = "str. Beketova 24"
                    },
                    new Restaurant
                    {
                        Id = 4,
                        ChainId = 3,
                        MenuId = 3, 
                        Name = "BurgerKing",
                        Phone = "+380099345514",
                        Address = "str. Studencheskay 24"
                    }
                );
            }
        }
    }
}
