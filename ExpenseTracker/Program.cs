namespace ExpenseTracker;
using ExpenseTracker.Model;
using ExpenseTracker.Controller;
class Program
{
    static void Main(string[] args)
    {
        Expense expense = new Expense("food", 20.00m, ExpenseCategory.Food, DateTime.Now);
        List<Expense> list = new List<Expense>();

        list.Add(expense);
        var filePath = "expenses.csv";
        ExpenseController.SaveExpenses(list, filePath);
        List<Expense> outputExpense = ExpenseController.LoadExpenses(filePath);
        foreach (var outexpense in outputExpense)
        {
            Console.WriteLine($"{outexpense}");
        }   
    }
}
