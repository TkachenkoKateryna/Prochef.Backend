
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prochef.Infrastructure.Entities;

namespace Prochef.Infrastructure.Configurations
{
    public class ChainConfiguration : IEntityTypeConfiguration<Chain>
    {
        public void Configure(EntityTypeBuilder<Chain> builder)
        {
            {
                builder.HasIndex(b => b.Name).IsUnique();
                builder.HasQueryFilter(b => !b.IsDeleted);
            }
        }
    }
}
