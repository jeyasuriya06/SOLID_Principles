package OCP.correct;

import java.util.Map;
import java.util.function.Consumer;

public class PaymentConfig {
    private final Map<String, Consumer<Double>> strategies;

    PaymentConfig() {
        strategies = Map.of(
            "CREDIT_CARD", amount -> System.out.println("Paying with card"),
            "UPI", amount -> System.out.println("Paying with UPI")
        );
    }

    void pay(String method, double amount) {
        Consumer<Double> strategy = strategies.get(method);

        if (strategy == null) {
            throw new IllegalArgumentException("Unsupported payment method: " + method);
        }

        strategy.accept(amount);
    }
}
