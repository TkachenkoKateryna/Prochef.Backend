
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prochef.Infrastructure.Entities;

namespace Prochef.Infrastructure.Configurations
{
    public class VendorCategoryConfiguration : IEntityTypeConfiguration<VendorCategory>
    {
        public void Configure(EntityTypeBuilder<VendorCategory> builder)
        {
            {
                builder.HasKey(vc => new { vc.CategoryId, vc.VendorId });

                builder.HasOne(e => e.Category)
                       .WithMany(e => e.VendorCategories)
                       .HasForeignKey(e => e.CategoryId)
                       .OnDelete(DeleteBehavior.Restrict);

                builder.HasOne(e => e.Vendor)
                       .WithMany(e => e.VendorCategories)
                       .HasForeignKey(e => e.VendorId)
                       .OnDelete(DeleteBehavior.Restrict);
            }
        }
    }
}
