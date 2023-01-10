
using System;
using Prochef.Core.Dtos.Request.Upsert;
using Prochef.Core.Dtos.Response.Expenses;

namespace Prochef.Application.Interfaces
{
    public interface IExpensesService
    {
        void AddExpense(UpsertExpenseRequest expense);
        GetWeekExpensesResponse GetWeekExpenses(DateTime startDate, DateTime endDate);
    }
}
