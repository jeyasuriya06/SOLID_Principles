using System;
using System.Collections.Generic;

public class PaymentConfig
{
    private readonly Dictionary<string, Action<double>> strategies;

    public PaymentConfig()
    {
        strategies = new Dictionary<string, Action<double>>
        {
            { "CREDIT_CARD", amount => Console.WriteLine("Paying with card") },
            { "UPI", amount => Console.WriteLine("Paying with UPI") }
        };
    }

    public void Pay(string method, double amount)
    {
        if (!strategies.TryGetValue(method, out var strategy))
        {
            throw new ArgumentException($"Unsupported payment method: {method}");
        }

        strategy(amount);
    }
}
