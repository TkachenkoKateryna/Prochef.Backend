using System;
using System.Collections.Generic;
using System.Text;

namespace Prochef.Core.Dtos.Response.Expenses
{
    public class ProductExpense
    {
        public int Key { get; set; }
        public string ProductName { get; set; }
        public double TotalAmount { get; set; }
    }

    public class WeekDayExpense
    {
        public int Key { get; set; }
        public DateTime Date { get; set; }
        public double TotalAmount { get; set; }
    }
}
