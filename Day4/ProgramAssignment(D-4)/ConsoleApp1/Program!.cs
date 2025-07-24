using System;

class Account
{
    // Step 1: Define private properties
    private string accountNumber;
    private decimal balance;
    private string ownerName;

    // Constructor to initialize account
    public Account(string accNumber, string owner)
    {
        accountNumber = accNumber;
        ownerName = owner;
        balance = 0;
    }

    // Step 2: Deposit method
    public void Deposit(decimal amount)
    {
        balance += amount;
        Console.WriteLine($"Deposited: ${amount:0.00}");
        ShowBalance();
    }

    // Step 2: Withdraw method
    public void Withdraw(decimal amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine($"Withdrew: ${amount:0.00}");
            ShowBalance();
        }
        else
        {
            Console.WriteLine("Insufficient balance.");
        }
    }

    // Step 2: Display current balance
    public void ShowBalance()
    {
        Console.WriteLine($"Account Balance: ${balance:0.00}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Step 3: Prompt for account details
        Console.WriteLine("Enter account number:");
        string accNumber = Console.ReadLine();

        Console.WriteLine("Enter owner name:");
        string owner = Console.ReadLine();

        // Step 5: Create Account instance
        Account acc = new Account(accNumber, owner);

        // Step 6: Perform transactions
        acc.Deposit(100.00m);
        acc.Withdraw(50.00m);
    }
}