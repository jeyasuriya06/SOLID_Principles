using System;

public class BankAccount
{
    protected double balance;

    public BankAccount(double initialBalance)
    {
        if (initialBalance < 0)
            throw new ArgumentException("Initial balance cannot be negative");

        balance = initialBalance;
    }

    public virtual void Withdraw(double amount)
    {
        if (amount < 0 || amount > balance)
            throw new ArgumentException("Invalid withdrawal amount");

        balance -= amount;
    }

    public double GetBalance()
    {
        return balance;
    }
}

public class OverdraftAccount : BankAccount
{
    public OverdraftAccount(double initialBalance) : base(initialBalance)
    {
    }

    // Allows negative balance
    public override void Withdraw(double amount)
    {
        if (amount < 0) throw new ArgumentException("Invalid withdrawal amount");

        balance -= amount;
    }
}
