
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prochef.Core.Entities;

namespace Prochef.Infrastructure.Configurations
{
    public class IngredientConfiguration : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder.HasKey(i => new { i.MenuItemId, i.ProductId });
            builder.HasKey(i => i.Id);
            builder.HasQueryFilter(i => !i.IsDeleted);

            builder.HasOne(e => e.Product)
                   .WithMany(e => e.Ingredients)
                   .HasForeignKey(e => e.ProductId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.MenuItem)
                   .WithMany(e => e.Ingredients)
                   .HasForeignKey(e => e.MenuItemId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new Ingredient { Id = 1, MenuItemId = 1, ProductId = 1, Weight = 0.2 },
                new Ingredient { Id = 2, MenuItemId = 1, ProductId = 2, Weight = 0.05 },
                new Ingredient { Id = 3, MenuItemId = 2, ProductId = 3, Weight = 0.3 },
                new Ingredient { Id = 4, MenuItemId = 2, ProductId = 6, Weight = 0.2 },
                new Ingredient { Id = 5, MenuItemId = 2, ProductId = 8, Weight = 0.05 },
                new Ingredient { Id = 6, MenuItemId = 2, ProductId = 9, Weight = 0.05 },
                new Ingredient { Id = 7, MenuItemId = 2, ProductId = 10, Weight = 0.1 },
                new Ingredient { Id = 8, MenuItemId = 2, ProductId = 11, Weight = 0.1 },
                new Ingredient { Id = 9, MenuItemId = 2, ProductId = 14, Weight = 1 },
                new Ingredient { Id = 10, MenuItemId = 3, ProductId = 5, Weight = 0.3 },
                new Ingredient { Id = 11, MenuItemId = 3, ProductId = 6, Weight = 0.2 },
                new Ingredient { Id = 12, MenuItemId = 3, ProductId = 8, Weight = 0.05 },
                new Ingredient { Id = 13, MenuItemId = 3, ProductId = 9, Weight = 0.05 },
                new Ingredient { Id = 14, MenuItemId = 3, ProductId = 10, Weight = 0.1 },
                new Ingredient { Id = 15, MenuItemId = 3, ProductId = 11, Weight = 0.1 },
                new Ingredient { Id = 16, MenuItemId = 3, ProductId = 14, Weight = 1 },
                new Ingredient { Id = 17, MenuItemId = 4, ProductId = 12, Weight = 0.3 },
                new Ingredient { Id = 18, MenuItemId = 4, ProductId = 13, Weight = 0.05 },
                new Ingredient { Id = 19, MenuItemId = 5, ProductId = 10, Weight = 0.1 },
                new Ingredient { Id = 20, MenuItemId = 5, ProductId = 11, Weight = 0.1 },
                new Ingredient { Id = 21, MenuItemId = 5, ProductId = 2, Weight = 0.05 },
                new Ingredient { Id = 22, MenuItemId = 5, ProductId = 4, Weight = 0.2 },
                new Ingredient { Id = 23, MenuItemId = 6, ProductId = 10, Weight = 0.1 },
                new Ingredient { Id = 24, MenuItemId = 6, ProductId = 11, Weight = 0.1 },
                new Ingredient { Id = 25, MenuItemId = 6, ProductId = 2, Weight = 0.05 },
                new Ingredient { Id = 26, MenuItemId = 6, ProductId = 4, Weight = 0.2 },
                new Ingredient { Id = 27, MenuItemId = 7, ProductId = 3, Weight = 0.3 },
                new Ingredient { Id = 28, MenuItemId = 7, ProductId = 6, Weight = 0.07 },
                new Ingredient { Id = 29, MenuItemId = 7, ProductId = 14, Weight = 1 },
                new Ingredient { Id = 30, MenuItemId = 7, ProductId = 2, Weight = 0.06 });
        }
    }
}
