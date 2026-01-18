namespace OCP.OverEngineered
{
    interface IPaymentMethod
    {
        void Pay(double amount);
    }

    class CreditCardPayment : IPaymentMethod
    {
        public void Pay(double amount)
        {
            Console.WriteLine("Paying with credit card");
        }
    }

    class PaymentService
    {
        private readonly IPaymentMethod _paymentMethod;

        public PaymentService(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public void Pay(double amount)
        {
            _paymentMethod.Pay(amount);
        }
    }
}
