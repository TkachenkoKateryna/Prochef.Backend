using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prochef.Core.Entities;

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

                builder.HasData(
                    new VendorCategory { CategoryId = 1, VendorId = 1 },
                    new VendorCategory { CategoryId = 2, VendorId = 2 },
                    new VendorCategory { CategoryId = 3, VendorId = 3 },
                    new VendorCategory { CategoryId = 4, VendorId = 4 },
                    new VendorCategory { CategoryId = 5, VendorId = 5 },
                    new VendorCategory { CategoryId = 6, VendorId = 6 },
                    new VendorCategory { CategoryId = 7, VendorId = 7 });
            }
        }
    }
}
