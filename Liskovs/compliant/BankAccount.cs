public class BankAccount
{
    protected double balance;

    public BankAccount(double initialBalance)
    {
        if (initialBalance < 0)
            throw new ArgumentException("Initial balance must be non-negative");

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

public class SavingsAccount : BankAccount
{
    public SavingsAccount(double initialBalance) : base(initialBalance)
    {
    }

    public override void Withdraw(double amount)
    {
        // Preserves invariant balance >= 0
        base.Withdraw(amount);
    }
}
