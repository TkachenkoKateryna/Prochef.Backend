using System;
using System.Collections.Generic;
using System.Text;
using Prochef.Core.Dtos.Response.Expenses;

namespace Prochef.Core.Dtos.Response.Expenses
{
    public class GetWeekExpensesResponse
    {
        public IEnumerable<ProductExpense> Products { get; set; } 
        public IEnumerable<WeekDayExpense> TotalDailyExpenses { get; set; } 
        public string MaxDay { get; set; }
        public string MinDay { get; set; }
    }
}
