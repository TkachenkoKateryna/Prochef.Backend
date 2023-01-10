using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prochef.Core.Entities;

namespace Prochef.Infrastructure.Configurations
{
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasIndex(b => b.Title).IsUnique();
            builder.HasQueryFilter(b => !b.IsDeleted);

            builder.HasData(
                new Menu
                {
                    Id = 1,
                    Title = "Macdonalds Menu"
                },
                new Menu
                {
                    Id = 2,
                    Title = "KFC Menu"
                },
                new Menu
                {
                    Id = 3,
                    Title = "BurgerKing Menu"
                }
            );
        }
    }
}
