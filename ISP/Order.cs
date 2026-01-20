public interface IOrderService
{
    void PlaceOrder();
    void CancelOrder();
    void GenerateInvoice();
    void IncreasePay();
}

public class Order
{
    private readonly IOrderService _orderService;

    public Order(IOrderService orderService)
    {
        _orderService = orderService;
    }

    public void CreateOrder()
    {
        _orderService.PlaceOrder(); // Only this is needed
    }
}

public class BasicOrderService : IOrderService
{
    public void PlaceOrder() { }

    public void CancelOrder() { }

    public void GenerateInvoice() { }

    public void IncreasePay()
    {
        throw new NotSupportedException();
    }
}
