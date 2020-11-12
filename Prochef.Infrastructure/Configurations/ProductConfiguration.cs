
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prochef.Infrastructure.Entities;

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
            }
        }
    }
}
