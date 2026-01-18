package OCP.correct;
import java.util.Map;


class CreditCardPayment implements PaymentMethod {
    public void pay(double amount) {
        System.out.println("Paying with credit card");
    }
}

class UpiPayment implements PaymentMethod {
    public void pay(double amount) {
        System.out.println("Paying with UPI");
    }
}

class PaymentService {

    private final Map<String, PaymentMethod> strategies;

    PaymentService(Map<String, PaymentMethod> strategies) {
        this.strategies = strategies;
    }

    void pay(String method, double amount) {
        PaymentMethod strategy = strategies.get(method);

        if (strategy == null) {
            throw new IllegalArgumentException("Unsupported payment method");
        }

        strategy.pay(amount);
    }
}
