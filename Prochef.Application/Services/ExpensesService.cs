using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using AutoMapper;
using Newtonsoft.Json;
using Prochef.Application.Interfaces;
using Prochef.Core.Dtos.Request.Upsert;
using Prochef.Core.Dtos.Response.Expenses;
using Prochef.Core.Entities;
using Prochef.Core.Interfaces.Repositories;

namespace Prochef.Application.Services
{
    public class ExpensesService : IExpensesService
    {
        private readonly IRepository<Expenses> _expensesRepository;
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;

        public ExpensesService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _expensesRepository = _uow.GetRepository<Expenses>();
            _mapper = mapper;
        }

        public void AddExpense(UpsertExpenseRequest expenseRequest)
        {
            var expenseEntity = _mapper.Map<Expenses>(expenseRequest);

            if (expenseEntity.Date == default(DateTime))
            {
                expenseEntity.Date = DateTime.Now;
            }
            _expensesRepository.Create(expenseEntity);
            _uow.Save();
        }

        public GetWeekExpensesResponse GetWeekExpenses(DateTime startDate, DateTime endDate)
        {
            var i = 0;
            var j = 0;
            var weekExpenses = new GetWeekExpensesResponse();
            var totalWeekExpenses = new List<WeekDayExpense>();
            var productExpenses = new List<ProductExpense>();
            var expenses = _expensesRepository
                .Find(expense => expense.Date >= startDate && expense.Date <= endDate)
                .OrderByDescending(expense => expense.Date)
                .ToList();

            expenses.ForEach(expense =>
            {

                if (totalWeekExpenses.Any(p => p.Date == expense.Date))
                {
                    var dEx = totalWeekExpenses.FirstOrDefault(p => p.Date == expense.Date);
                    totalWeekExpenses[dEx.Key].TotalAmount = Math.Round(dEx.TotalAmount + expense.UsedQuantity, 2);
                }
                else
                {
                    totalWeekExpenses.Add(new WeekDayExpense() { Key = i++, Date = expense.Date,  TotalAmount = expense.UsedQuantity});
                }

                if (productExpenses.Any(p => p.ProductName == expense.ProductName))
                {
                    var prEx = productExpenses.FirstOrDefault(p => p.ProductName == expense.ProductName);
                    productExpenses[prEx.Key].TotalAmount = Math.Round(prEx.TotalAmount + expense.UsedQuantity, 2);
                }
                else
                {
                    productExpenses.Add(new ProductExpense() { Key = j++, ProductName = expense.ProductName, TotalAmount = expense.UsedQuantity });
                }
            });

            var sortedExpense = totalWeekExpenses.OrderBy(o => o.TotalAmount).ToList();

            weekExpenses.MinDay = sortedExpense.LastOrDefault().Date.DayOfWeek.ToString();
            weekExpenses.MaxDay = sortedExpense.FirstOrDefault().Date.DayOfWeek.ToString();
            weekExpenses.TotalDailyExpenses = totalWeekExpenses.OrderBy(o => o.Date);
            weekExpenses.Products = productExpenses;

            return weekExpenses;
        }
    }
}
