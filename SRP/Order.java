package SRP;

public class Order {
    int size = 2;
}

class OrderValidator {
    boolean isValid(Order order) {
        return order.size > 0;
    }
}

class OrderSaver {
    void save(Order order) {
        System.out.println("Saving order to DB");
    }
}

class OrderEmailSender {
    void send(Order order) {
        System.out.println("Sending confirmation email");
    }
}

class OrderLogger {
    void log(Order order) {
        System.out.println("Logging order");
    }
}

class OrderService {
    void placeOrder(Order order) {
        validate(order);
        persist(order);
        notifyUser(order);
        audit(order);
    }

    private void audit(Order order) {
        throw new UnsupportedOperationException("Unimplemented method 'audit'");
    }

    private void notifyUser(Order order) {
        throw new UnsupportedOperationException("Unimplemented method 'notifyUser'");
    }

    private void persist(Order order) {
        throw new UnsupportedOperationException("Unimplemented method 'persist'");
    }

    private void validate(Order order) {
        throw new UnsupportedOperationException("Unimplemented method 'validate'");
    }
}
