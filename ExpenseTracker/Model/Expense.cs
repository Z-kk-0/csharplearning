namespace ExpenseTracker.Model;
public enum ExpenseCategory
    {
     Food,
      Transport,
     Hobby,
     Other,
    }
public class Expense(string description, decimal amount, ExpenseCategory category, DateTime date)
{
    public string Description { get; set; } = description;
    public decimal Amount { get; set; } = amount;
    public DateTime Date { get; set; } = date;
    public ExpenseCategory Category { get; set; } = category;

    public override string ToString()
{
    return $"{Date:yyyy-MM-dd} | {Category} | {Amount:C} | {Description}";
}
}