package SRP.violations;

public class Invoice {
    int amount() {
        return 100;
    }
    String generateInvoice(Invoice invoice) {
        // validation logic
        // calculation logic
        // formatting logic
        return "Invoice: " + invoice.amount();
    }
}
