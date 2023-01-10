
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prochef.Core.Entities;

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

                builder.HasData(
                    new MenuItem { Id = 1, Name = "French Fries", Description = "Potato fried in the oil", SectionId = 1 },
                    new MenuItem { Id = 2, Name = "Chicken Burger", Description = "2 Buns with chicken, cheese and vegetables", SectionId = 1 },
                    new MenuItem { Id = 3, Name = "Beef burger", Description = "2 Buns with beef, cheese and vegetables", SectionId = 1 },
                    new MenuItem { Id = 4, Name = "Ice-cream", Description = "Ice-cream with chocolate", SectionId = 2 },
                    new MenuItem { Id = 5, Name = "Salad with ham", Description = "Vegetables with ham", SectionId = 3 },
                    new MenuItem { Id = 6, Name = "Salad with salmon", Description = "Vegetables with salmon", SectionId = 3 },
                    new MenuItem { Id = 7, Name = "Chicken Nuggets", Description = "Chicken fried in flour and eggs", SectionId = 1 });
            }
        }
    }
}
