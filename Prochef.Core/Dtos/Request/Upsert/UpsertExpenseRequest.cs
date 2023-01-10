
using System;

namespace Prochef.Core.Dtos.Request.Upsert
{
    public class UpsertExpenseRequest
    {
        public string ProductName { get; set; }
        public double UsedQuantity { get; set; }
        public DateTime Date { get; set; }
    }
}
