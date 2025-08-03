namespace ExpenseTracker.Controller;

using ExpenseTracker.Model;
using System.Text;
class ExpenseController
{
    private static string EscapeCsv(string input)
    {
        if (input.Contains(',') || input.Contains('"') || input.Contains('\n'))
        {
            input = input.Replace("\"", "\"\"");
            return $"\"{input}\"";
        }
        return input;
    }

    public static void SaveExpenses(List<Expense> expenses, string filePath)
    {
        using var writer = new StreamWriter(filePath);
        writer.WriteLine("Date,Category,Amount,Description");
        foreach (var expense in expenses)
        {
            string line = $"{expense.Date:yyyy-MM-dd},{expense.Category},{expense.Amount},{EscapeCsv(expense.Description)}";
            writer.WriteLine(line);
        }
    }

    public static List<Expense> LoadExpenses(string filePath)
    {
        var expenses = new List<Expense>();
        var lines = File.ReadAllLines(filePath);
        for (int i = 1; i < lines.Length; i++)
        {
            var parts = ParseCsvLine(lines[i]);

            var date = DateTime.Parse(parts[0]);
            var category = Enum.Parse<ExpenseCategory>(parts[1]);
            var amount = decimal.Parse(parts[2]);
            var description = parts[3];

            var expense = new Expense(description, amount, category, date);
            expenses.Add(expense);
        }
        return expenses;
    }

    private static string[] ParseCsvLine(string line)
    {
        var values = new List<string>();

        var current = new StringBuilder();

        bool inQoutes = false;

        for (int i = 0; i < line.Length; i++)
        {
            char c = line[i];
            if (inQoutes)
            {
                if (c == '"' && i + 1 < line.Length && line[i + 1] == '"')
                {
                    current.Append('"');
                    i++;
                }
                else if (c == '"')
                {
                    inQoutes = false;
                }
                else
                {
                    current.Append(c);
                }
            }
            else
            {
                if (c == ',')
                {
                    values.Add(current.ToString());
                    current.Clear();
                }
                else if (c == '"')
                {
                    inQoutes = true;
                }
                else
                {
                    current.Append(c);
                }
            }
        }
            values.Add(current.ToString());
            return values.ToArray();
    }
}