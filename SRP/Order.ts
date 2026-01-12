export class Order {
    size: number = 2;
}

export class OrderValidator {
    isValid(order: Order): boolean {
        return order.size > 0;
    }
}

export class OrderSaver {
    save(order: Order): void {
        console.log("Saving order to DB");
    }
}

export class OrderEmailSender {
    send(order: Order): void {
        console.log("Sending confirmation email");
    }
}

export class OrderLogger {
    log(order: Order): void {
        console.log("Logging order");
    }
}

export class OrderService {
    constructor(
        private readonly validator: OrderValidator,
        private readonly saver: OrderSaver,
        private readonly emailSender: OrderEmailSender,
        private readonly logger: OrderLogger
    ) { }

    placeOrder(order: Order): void {
        if (!this.validator.isValid(order)) {
            throw new Error("Invalid order");
        }

        this.saver.save(order);
        this.emailSender.send(order);
        this.logger.log(order);
    }
}
