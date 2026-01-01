using System;
using System.ComponentModel.DataAnnotations;

namespace ExpenseTracker.Api.Dtos;

public class CreateExpenseDto
{
    [Required]
    public string Title { get; set; } = string.Empty;

    [Range(0.01, double.MaxValue)]
    public decimal Amount { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public string Category { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;
}
