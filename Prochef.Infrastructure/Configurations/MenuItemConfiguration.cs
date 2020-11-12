
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prochef.Infrastructure.Entities;

namespace Prochef.Infrastructure.Configurations
{
    public class MenuItemConfiguration : IEntityTypeConfiguration<MenuItem>
    {
        public void Configure(EntityTypeBuilder<MenuItem> builder)
        {
            {
                builder.HasQueryFilter(i => !i.IsDeleted);

                builder.HasOne(i => i.Section)
                       .WithMany(s => s.MenuItems)
                       .HasForeignKey(i => i.SectionId)
                       .OnDelete(DeleteBehavior.Restrict);
            }
        }
    }
}
