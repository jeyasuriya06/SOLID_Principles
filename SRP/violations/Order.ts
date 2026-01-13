export class Order {
}

export interface Logger {
    log(message: string): void;
}

export class OrderService {
    constructor(
        private db: unknown,   // persistence concern
        private logger: Logger // logging concern
    ) { }

    placeOrder(order: Order): void {
        // everything happens here
    }
}
