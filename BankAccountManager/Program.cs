namespace BankAccountManager;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        decimal depositAmount;
        decimal withdrawAmount;

        Console.WriteLine("please Register your Name");
        string inputName = Console.ReadLine();
        BankAccount account = new BankAccount(inputName);
        Console.WriteLine($"Welcome to your BankAccountManager {account.owner}");

        while (exit == false)
        {
            Console.WriteLine("Please enter a Number and select your Action: \n 1. Deposit \n 2. Withdraw \n 3. Show Balance \n 4. Exit Programm");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            switch (key.KeyChar)
            {
                case '1':
                    Console.WriteLine("You Chose Deposit");
                    string inputDeposit = Console.ReadLine();
                    if (!decimal.TryParse(inputDeposit, out depositAmount))
                    {
                        Console.WriteLine("please enter a valid number");
                    }
                    account.Deposit(depositAmount);
                    break;
                case '2':
                    Console.WriteLine("You chose Withdraw");
                    string inputWithdraw = Console.ReadLine();
                    if (!decimal.TryParse(inputWithdraw, out withdrawAmount))
                    {
                        Console.WriteLine("please enter a valid number");
                    }
                    account.Withdraw(withdrawAmount);
                    break;
                case '3':
                    Console.WriteLine($"Your Account Balance is: {account.GetBalance():F2}");
                    break;
                case '4':
                    Console.WriteLine("Exited the programm Goodbye :)");
                    exit = true;
                    break;
            }
        }
    }
}
