type PaymentStrategy = (amount: number) => void;

class PaymentConfig {
    private readonly strategies: Map<string, PaymentStrategy>;

    constructor() {
        this.strategies = new Map<string, PaymentStrategy>([
            ["CREDIT_CARD", (amount) => console.log("Paying with card")],
            ["UPI", (amount) => console.log("Paying with UPI")]
        ]);
    }

    pay(method: string, amount: number): void {
        const strategy = this.strategies.get(method);

        if (!strategy) {
            throw new Error(`Unsupported payment method: ${method}`);
        }

        strategy(amount);
    }
}
