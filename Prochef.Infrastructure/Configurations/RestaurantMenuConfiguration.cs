using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prochef.Infrastructure.Entities;

namespace Prochef.Infrastructure.Configurations
{
    public class RestaurantMenuConfiguration : IEntityTypeConfiguration<RestaurantMenu>
    {
        public void Configure(EntityTypeBuilder<RestaurantMenu> builder)
        {
            {
                builder.HasKey(e => new { e.MenuId, e.RestaurantId });

                builder.HasOne(e => e.Restaurant)
                       .WithMany(e => e.RestaurantMenus)
                       .HasForeignKey(e => e.RestaurantId)
                       .OnDelete(DeleteBehavior.Restrict);

                builder.HasOne(e => e.Menu)
                       .WithMany(e => e.RestaurantMenus)
                       .HasForeignKey(e => e.MenuId)
                       .OnDelete(DeleteBehavior.Restrict);
            }
        }
    }
}
