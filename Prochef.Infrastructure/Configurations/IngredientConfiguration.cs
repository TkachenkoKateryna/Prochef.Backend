
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prochef.Infrastructure.Entities;

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
        }
    }
}
