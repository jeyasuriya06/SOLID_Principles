namespace OCP.Violations
{
    class PaymentService
    {
        public void Pay(string method, double amount)
        {
            if (method == "CREDIT_CARD")
            {
                Console.WriteLine("Paying with credit card");
            }
            else if (method == "UPI")
            {
                Console.WriteLine("Paying with UPI");
            }
            else if (method == "PAYPAL")
            {
                Console.WriteLine("Paying with PayPal");
            }
        }
    }
}
