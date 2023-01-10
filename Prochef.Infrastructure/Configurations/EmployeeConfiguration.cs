
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prochef.Core.Entities;

namespace Prochef.Infrastructure.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            {
                builder.HasIndex(b => b.Email).IsUnique();
                builder.HasIndex(b => b.Phone).IsUnique();
                builder.HasQueryFilter(b => !b.IsDeleted);

                builder.HasOne(p => p.Role)
                       .WithMany(p => p.Employees)
                       .HasForeignKey(p => p.RoleId)
                       .OnDelete(DeleteBehavior.Restrict);

                builder.HasOne(p => p.Restaurant)
                      .WithMany(p => p.Employees)
                      .HasForeignKey(p => p.RestaurantId)
                      .OnDelete(DeleteBehavior.Restrict);
            }
        }
    }
}
