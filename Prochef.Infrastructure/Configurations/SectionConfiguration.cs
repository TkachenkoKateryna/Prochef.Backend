
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prochef.Infrastructure.Entities;

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
        }
    }
}
