namespace SRP
{
    public class Order
    {
        public int Size { get; set; } = 2;
    }

    class OrderValidator
    {
        public bool IsValid(Order order)
        {
            return order.Size > 0;
        }
    }

    class OrderSaver
    {
        public void Save(Order order)
        {
            Console.WriteLine("Saving order to DB");
        }
    }

    class OrderEmailSender
    {
        public void Send(Order order)
        {
            Console.WriteLine("Sending confirmation email");
        }
    }

    class OrderLogger
    {
        public void Log(Order order)
        {
            Console.WriteLine("Logging order");
        }
    }

    class OrderService
    {
        private readonly OrderValidator _validator;
        private readonly OrderSaver _saver;
        private readonly OrderEmailSender _emailSender;
        private readonly OrderLogger _logger;

        public OrderService(
            OrderValidator validator,
            OrderSaver saver,
            OrderEmailSender emailSender,
            OrderLogger logger)
        {
            _validator = validator;
            _saver = saver;
            _emailSender = emailSender;
            _logger = logger;
        }

        public void PlaceOrder(Order order)
        {
            if (!_validator.IsValid(order))
            {
                throw new ArgumentException("Invalid order");
            }

            _saver.Save(order);
            _emailSender.Send(order);
            _logger.Log(order);
        }
    }
}
