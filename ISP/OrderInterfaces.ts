interface OrderPlacer {
    placeOrder(): void;
}

interface OrderCanceler {
    cancelOrder(): void;
}

interface InvoiceGenerator {
    generateInvoice(): void;
}

interface PromotionSender {
    sendPromotionalEmail(): void;
}
