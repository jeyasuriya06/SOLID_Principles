class PaymentService {
    pay(method: string, amount: number): void {
        if (method === "CREDIT_CARD") {
            console.log("Paying with credit card");
        } else if (method === "UPI") {
            console.log("Paying with UPI");
        } else if (method === "PAYPAL") {
            console.log("Paying with PayPal");
        }
    }
}
