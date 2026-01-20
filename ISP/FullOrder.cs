public class FullOrderService :
    IOrderPlacer, IOrderCanceler, IInvoiceGenerator, IPromotionSender
{
    public void PlaceOrder() { }
    public void CancelOrder() { }
    public void GenerateInvoice() { }
    public void SendPromotionalEmail() { }
}
