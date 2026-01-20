class BankAccount {
    protected balance: number;

    constructor(initialBalance: number) {
        if (initialBalance < 0) {
            throw new Error("Initial balance must be non-negative");
        }
        this.balance = initialBalance;
    }

    withdraw(amount: number): void {
        if (amount < 0 || amount > this.balance) {
            throw new Error("Invalid withdrawal amount");
        }
        this.balance -= amount;
    }

    getBalance(): number {
        return this.balance;
    }
}

class SavingsAccount extends BankAccount {
    withdraw(amount: number): void {
        // Preserves invariant
        super.withdraw(amount);
    }
}
