interface OrderService {
    void placeOrder();
    void cancelOrder();
    void generateInvoice();
    void increasePay();
}
@SuppressWarnings("unused")
public class Order {

    private final OrderService orderService;

    
    Order(OrderService orderService) {
        this.orderService = orderService;
    }

    public void createOrder() {
        orderService.placeOrder();   // Only this is needed
    }
}

@SuppressWarnings("unused")
class BasicOrderService implements OrderService {
    @Override
    public void placeOrder() { }
    @Override
    public void cancelOrder() {  }
    @Override
    public void generateInvoice() {  }
    @Override
    public void increasePay() {
        throw new UnsupportedOperationException();
    }
}

interface OrderPlacer {
    void placeOrder();
}

interface OrderCanceler {
    void cancelOrder();
}

interface InvoiceGenerator {
    void generateInvoice();
}

interface PromotionSender {
    void sendPromotionalEmail();
}

@SuppressWarnings("unused")
class BasicOrder implements OrderPlacer, OrderCanceler {

    @Override
    public void placeOrder() {
        System.out.println("Order placed");
    }

    @Override
    public void cancelOrder() {
        System.out.println("Order canceled");
    }

}

@SuppressWarnings("unused")
class FullOrderService implements 
        OrderPlacer, OrderCanceler, InvoiceGenerator, PromotionSender {

    @Override
    public void placeOrder() { }
    @Override
    public void cancelOrder() { }
    @Override
    public void generateInvoice() {}
    @Override
    public void sendPromotionalEmail() {}
}
