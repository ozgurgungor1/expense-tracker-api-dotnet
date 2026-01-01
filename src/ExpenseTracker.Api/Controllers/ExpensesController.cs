using Microsoft.AspNetCore.Mvc;
using ExpenseTracker.Api.Models;
using ExpenseTracker.Api.Dtos;

namespace ExpenseTracker.Api.Controllers;

[ApiController]
[Route("api/expenses")]
public class ExpensesController : ControllerBase
{
    private static readonly List<Expense> Expenses = new();

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(Expenses);
    }

    [HttpPost]
    public IActionResult Create(CreateExpenseDto dto)
    {
        var expense = new Expense
        {
            Id = Guid.NewGuid(),
            Title = dto.Title,
            Amount = dto.Amount,
            Date = dto.Date,
            Category = dto.Category,
            Description = dto.Description
        };

        Expenses.Add(expense);

        return CreatedAtAction(nameof(GetAll), expense);
    }
}
