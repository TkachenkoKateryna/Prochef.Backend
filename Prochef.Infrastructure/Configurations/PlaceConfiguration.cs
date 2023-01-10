
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prochef.Core.Entities;

namespace Prochef.Infrastructure.Configurations
{
    public class PlaceConfiguration : IEntityTypeConfiguration<Place>
    {
        public void Configure(EntityTypeBuilder<Place> builder)
        {
            {
                builder.HasIndex(b => b.Name).IsUnique();
                builder.HasQueryFilter(b => !b.IsDeleted);

                builder.HasData(
                    new Place { Id = 1, Name = "Fridge" },
                    new Place { Id = 2, Name = "Storeroom" },
                    new Place { Id = 3, Name = "Pantry" });
            }
        }
    }
}
