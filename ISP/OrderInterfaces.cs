public interface IOrderPlacer
{
    void PlaceOrder();
}

public interface IOrderCanceler
{
    void CancelOrder();
}

public interface IInvoiceGenerator
{
    void GenerateInvoice();
}

public interface IPromotionSender
{
    void SendPromotionalEmail();
}
