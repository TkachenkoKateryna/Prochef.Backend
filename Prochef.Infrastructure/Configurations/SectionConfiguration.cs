using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prochef.Core.Entities;

namespace Prochef.Infrastructure.Configurations
{
    public class SectionConfiguration : IEntityTypeConfiguration<MenuSection>
    {
        public void Configure(EntityTypeBuilder<MenuSection> builder)
        {
            builder.HasIndex(s => s.Name).IsUnique();
            builder.HasQueryFilter(s => !s.IsDeleted);

            builder.HasOne(s => s.Menu)
                .WithMany(m => m.Sections)
                .HasForeignKey(s => s.MenuId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new MenuSection {Id = 1, Name = "Main dishes", MenuId = 1},
                new MenuSection {Id = 2, Name = "Desserts", MenuId = 1},
                new MenuSection {Id = 3, Name = "Drinks", MenuId = 1},
                new MenuSection {Id = 4, Name = "Salads", MenuId = 1});
        }
    }
}
