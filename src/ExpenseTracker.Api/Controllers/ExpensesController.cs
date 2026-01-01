[HttpPost]
public IActionResult Create(CreateExpenseDto dto)
{
    if (!ModelState.IsValid)
    {
        return BadRequest(ModelState);
    }

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
