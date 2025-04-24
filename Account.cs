using System;

public class Account
{
    public string Name { get; }
    private double balance;

    public double Balance => balance;

    public Account(string name, double initialBalance)
    {
        if (initialBalance < 0)
            throw new ArgumentException("Initial balance cannot be negative.");

        Name = name;
        balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount < 0)
            throw new ArgumentException("Cannot deposit a negative amount.");
        balance += amount;
    }

    public void Withdrawal(double amount)
    {
        if (amount < 0)
            throw new ArgumentException("Cannot withdraw a negative amount.");
        if (balance - amount < 0)
            throw new InvalidOperationException("Insufficient funds.");
        balance -= amount;
    }
}
