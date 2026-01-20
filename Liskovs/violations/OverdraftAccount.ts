class OverdraftAccount extends BankAccount {
    // Allows negative balance
    override withdraw(amount: number): void {
        if (amount < 0) {
            throw new Error("Invalid withdrawal amount");
        }
        this.balance -= amount;
    }
}
