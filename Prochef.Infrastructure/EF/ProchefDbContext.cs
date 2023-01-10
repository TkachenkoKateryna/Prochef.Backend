using Microsoft.EntityFrameworkCore;
using Prochef.Core.Entities;
using System.Reflection;

namespace Prochef.Infrastructure.EF
{
    public class ProchefDbContext : DbContext
    {
        public ProchefDbContext(DbContextOptions<ProchefDbContext> options)
            : base(options)
        {
        }

        public DbSet<Chain> Chains { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuSection> MenuSections { get; set; }
        public DbSet<ProductListItems> ProductListItems { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Expenses> Expenses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<VendorCategory> VendorCategories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
