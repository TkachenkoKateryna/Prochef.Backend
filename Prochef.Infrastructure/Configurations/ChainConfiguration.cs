
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prochef.Core.Entities;

namespace Prochef.Infrastructure.Configurations
{
    public class ChainConfiguration : IEntityTypeConfiguration<Chain>
    {
        public void Configure(EntityTypeBuilder<Chain> builder)
        {
            {
                builder.HasIndex(b => b.Name).IsUnique();
                builder.HasQueryFilter(b => !b.IsDeleted);

                builder.HasData(
                    new Chain { Id = 1, Name = "Macdonalds", City = "Kharkov", Country = "Ukraine" },
                    new Chain { Id = 2, Name = "KFC", City = "Kharkov", Country = "Ukraine" },
                    new Chain { Id = 3, Name = "BurgerKing", City = "Kharkov", Country = "Ukraine"});
            }
        }
    }
}
