using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prochef.Core.Entities;

namespace Prochef.Infrastructure.Configurations
{
    public class ExpensesConfiguration : IEntityTypeConfiguration<Expenses>
    {
        public void Configure(EntityTypeBuilder<Expenses> builder)
        {
            {
                builder.HasData(
                    new Expenses {Id = 1, Date = new DateTime(2020, 11, 2), ProductName = "Potato", UsedQuantity = 0.2},
                    new Expenses {Id = 2, Date = new DateTime(2020, 11, 2), ProductName = "Potato", UsedQuantity = 0.2},
                    new Expenses {Id = 3, Date = new DateTime(2020, 11, 2), ProductName = "Meet", UsedQuantity = 0.3},
                    new Expenses {Id = 4, Date = new DateTime(2020, 11, 3), ProductName = "Meet", UsedQuantity = 0.3},

                    new Expenses {Id = 5, Date = new DateTime(2020, 11, 3), ProductName = "Potato", UsedQuantity = 0.1},
                    new Expenses {Id = 6, Date = new DateTime(2020, 11, 3), ProductName = "Potato", UsedQuantity = 0.1},
                    new Expenses {Id = 7, Date = new DateTime(2020, 11, 3), ProductName = "Meet", UsedQuantity = 0.1},
                    new Expenses {Id = 8, Date = new DateTime(2020, 11, 3), ProductName = "Meet", UsedQuantity = 0.1},

                    new Expenses {Id = 9, Date = new DateTime(2020, 11, 4), ProductName = "IceCream", UsedQuantity = 0.2},
                    new Expenses {Id = 10, Date = new DateTime(2020, 11, 4), ProductName = "Potato", UsedQuantity = 0.25},
                    new Expenses {Id = 11, Date = new DateTime(2020, 11, 4), ProductName = "Meet", UsedQuantity = 0.25},
                    new Expenses {Id = 12, Date = new DateTime(2020, 11, 4), ProductName = "Meet", UsedQuantity = 0.25},

                    new Expenses {Id = 13, Date = new DateTime(2020, 11, 5), ProductName = "IceCream", UsedQuantity = 0.3},
                    new Expenses {Id = 14, Date = new DateTime(2020, 11, 5), ProductName = "IceCream", UsedQuantity = 0.3},
                    new Expenses {Id = 15, Date = new DateTime(2020, 11, 5), ProductName = "Potato", UsedQuantity = 0.15},
                    new Expenses {Id = 16, Date = new DateTime(2020, 11, 5), ProductName = "Potato", UsedQuantity = 0.15},

                    new Expenses {Id = 17, Date = new DateTime(2020, 11, 6), ProductName = "Potato", UsedQuantity = 0.3},
                    new Expenses {Id = 18, Date = new DateTime(2020, 11, 6), ProductName = "Meet", UsedQuantity = 0.2},
                    new Expenses {Id = 19, Date = new DateTime(2020, 11, 6), ProductName = "Meet", UsedQuantity = 0.2},
                    new Expenses {Id = 20, Date = new DateTime(2020, 11, 6), ProductName = "Meet", UsedQuantity = 0.2},

                    new Expenses {Id = 21, Date = new DateTime(2020, 11, 7), ProductName = "Potato", UsedQuantity = 0.5},
                    new Expenses {Id = 22, Date = new DateTime(2020, 11, 7), ProductName = "Potato", UsedQuantity = 0.5},
                    new Expenses {Id = 23, Date = new DateTime(2020, 11, 7), ProductName = "Meet", UsedQuantity = 0.3},
                    new Expenses {Id = 24, Date = new DateTime(2020, 11, 7), ProductName = "Meet", UsedQuantity = 0.3},

                    new Expenses {Id = 25, Date = new DateTime(2020, 11, 8), ProductName = "IceCream", UsedQuantity = 0.25},
                    new Expenses {Id = 26, Date = new DateTime(2020, 11, 8), ProductName = "Potato", UsedQuantity = 0.3},
                    new Expenses {Id = 27, Date = new DateTime(2020, 11, 8), ProductName = "IceCream", UsedQuantity = 0.25},
                    new Expenses {Id = 28, Date = new DateTime(2020, 11, 8), ProductName = "Meet", UsedQuantity = 0.4}
                );
            }
        }
    }
}
