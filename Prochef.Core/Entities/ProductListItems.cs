using System;
using Prochef.Core.Entities.Base;

namespace Prochef.Core.Entities
{
    public enum ListItemStatus
    {
        Processing,
        Processed,
        Declined
    }

    public class ProductListItems : BaseEntity
    {
        public string ProductName { get; set; }
        public double Quantity { get; set; }
        public ListItemStatus Status { get; set; }
        public DateTime Date { get; set; }
    }
}
