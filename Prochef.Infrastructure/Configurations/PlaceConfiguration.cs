
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prochef.Infrastructure.Entities;

namespace Prochef.Infrastructure.Configurations
{
    public class PlaceConfiguration : IEntityTypeConfiguration<Place>
    {
        public void Configure(EntityTypeBuilder<Place> builder)
        {
            {
                builder.HasIndex(b => b.Name).IsUnique();
                builder.HasQueryFilter(b => !b.IsDeleted);
            }
        }
    }
}
