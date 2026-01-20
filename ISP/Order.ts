interface OrderService {
    placeOrder(): void;
    cancelOrder(): void;
    generateInvoice(): void;
    increasePay(): void;
}

class Order {
    private orderService: OrderService;

    constructor(orderService: OrderService) {
        this.orderService = orderService;
    }

    createOrder(): void {
        this.orderService.placeOrder();
    }
}

class BasicOrderService implements OrderService {
    placeOrder(): void {}

    cancelOrder(): void {}

    generateInvoice(): void {}

    increasePay(): void {
        throw new Error("Not supported");
    }
}
