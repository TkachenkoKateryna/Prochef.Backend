using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prochef.Core.Entities;

namespace Prochef.Infrastructure.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasQueryFilter(p => !p.IsDeleted);

            builder.HasData(
                new Category {Id = 1, Name = "Vegetables"},
                new Category {Id = 2, Name = "Fruits"},
                new Category {Id = 3, Name = "Dairy"},
                new Category {Id = 4, Name = "Meet"},
                new Category {Id = 5, Name = "Eggs"},
                new Category {Id = 6, Name = "Seafood"},
                new Category {Id = 7, Name = "Cereals"});
        }
    }
}
