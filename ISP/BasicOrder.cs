public class BasicOrder : IOrderPlacer, IOrderCanceler
{
    public void PlaceOrder()
    {
        Console.WriteLine("Order placed");
    }

    public void CancelOrder()
    {
        Console.WriteLine("Order canceled");
    }
}
