using System;
using Microsoft.AspNetCore.Mvc;
using Prochef.Application.Interfaces;
using Prochef.Core.Dtos.Request.Upsert;

namespace Prochef.WebApi.Controllers
{
    public class ExpensesController : Controller
    {
        private readonly IExpensesService _expensesService;

        public ExpensesController(IExpensesService expensesService)
        {
            _expensesService = expensesService;
        }

        [HttpGet("expenses/getWeekReport")]
        public IActionResult GetWeekExpenses(DateTime startDate, DateTime endDate)
        {
            return Json(_expensesService.GetWeekExpenses(startDate, endDate));
        }

        [HttpPost("expenses/addExpense")]
        public IActionResult AddExpense(UpsertExpenseRequest expenseRequest)
        {
            try
            {
                _expensesService.AddExpense(expenseRequest);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
