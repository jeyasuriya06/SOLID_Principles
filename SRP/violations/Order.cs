namespace SRP.Violations
{
    public class Order
    {
    }

    public class OrderService
    {
        private object db;          // persistence concern
        private ILogger logger;     // logging concern

        public void PlaceOrder(Order order)
        {
            // everything happens here
        }
    }

    // Sample logger abstraction for demonstration
    public interface ILogger
    {
        void Log(string message);
    }
}
