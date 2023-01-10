using System;
using System.Collections.Generic;
using System.Text;
using Prochef.Core.Entities.Base;

namespace Prochef.Core.Entities
{
    public class Expenses : BaseEntity
    {
        public string ProductName { get; set; }
        public double UsedQuantity { get; set; }
        public DateTime Date { get; set; }
    }
}
