
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prochef.Infrastructure.Entities;

namespace Prochef.Infrastructure.Configurations
{
    public class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant> 
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder) 
        {
            {
                builder.HasIndex(b => b.Name).IsUnique();
                builder.HasQueryFilter(b => !b.IsDeleted);

                builder.HasOne(p => p.Chain)
                       .WithMany(p => p.Restaurants)
                       .HasForeignKey(p => p.ChainId)
                       .IsRequired(false)
                       .OnDelete(DeleteBehavior.Restrict);
            }
        }
    }
}
