class BankAccount {
    protected double balance;

    public BankAccount(double initialBalance) {
        if (initialBalance < 0) throw new IllegalArgumentException();
        this.balance = initialBalance;
    }

    public void withdraw(double amount) {
        if (amount < 0 || amount>balance) throw new IllegalArgumentException();
        balance -= amount;
    }

    public double getBalance(){
        return balance;
    }
}

class SavingsAccount extends BankAccount {
    @Override
    public void withdraw(double amount) {
        super.withdraw(amount);
    }
}