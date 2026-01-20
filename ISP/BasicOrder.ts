class BasicOrder implements OrderPlacer, OrderCanceler {
    placeOrder(): void {
        console.log("Order placed");
    }

    cancelOrder(): void {
        console.log("Order canceled");
    }
}
