namespace BankAccountManager;

public class BankAccount
{
    public string owner;
    private decimal accountBalance;

    public BankAccount(string name)
    {
        owner = name;
        accountBalance = 0;
    }


    public bool Withdraw(decimal amount)
    {
        if (amount > accountBalance)
        {
            Console.WriteLine($"you cannot Withdraw a amount below zero current Balance: {accountBalance:F2}");
            return false;
        }
        else
        {
            accountBalance -= amount;
            Console.WriteLine($"successfully withdrew {amount} from your account");
            return true;
        }
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("please enter a valid amount");
            return;
        }
        accountBalance += amount;
    }

    public decimal GetBalance() {
        return accountBalance;
    }

}
