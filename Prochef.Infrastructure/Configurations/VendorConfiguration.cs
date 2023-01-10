using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prochef.Core.Entities;

namespace Prochef.Infrastructure.Configurations
{
    public class VendorConfiguration : IEntityTypeConfiguration<Vendor>
    {
        public void Configure(EntityTypeBuilder<Vendor> builder)
        {
            builder.HasIndex(s => s.Name).IsUnique();
            builder.HasQueryFilter(s => !s.IsDeleted);

            builder.HasData(
                new Vendor
                {
                    Id = 1, Name = "VegetablesDelivery", Email = "vegetablesDelivery@email.com", Address = "str Sumskay 24",
                    Phone = "+380123123123", DeliveryTime = 3
                },
                new Vendor
                {
                    Id = 2, Name = "FruitDelivery", Email = "fruitDelivery@email.com", Address = "str Sumskay 23",
                    Phone = "+380123123124", DeliveryTime = 2
                },
                new Vendor
                {
                    Id = 3, Name = "DairyDelivery", Email = "dairyDelivery@email.com", Address = "str Sumskay 22",
                    Phone = "+380123123125", DeliveryTime = 3
                },
                new Vendor
                {
                    Id = 4, Name = "MeetDelivery", Email = "meetDelivery@email.com", Address = "str Sumskay 21",
                    Phone = "+380123123126", DeliveryTime = 4
                },
                new Vendor
                {
                    Id = 5, Name = "EggsDelivery", Email = "eggsDelivery@email.com", Address = "str Sumskay 20",
                    Phone = "+380123123127", DeliveryTime = 3
                },
                new Vendor
                {
                    Id = 6, Name = "SeafoodDelivery", Email = "seafoodDelivery@email.com", Address = "str Sumskay 19",
                    Phone = "+380123123128", DeliveryTime = 2
                },
                new Vendor
                {
                    Id = 7, Name = "CerealsDelivery", Email = "cerealsDelivery@email.com", Address = "str Sumskay 18",
                    Phone = "+380123123129", DeliveryTime = 3
                });
        }
    }
}