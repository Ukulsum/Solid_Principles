using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Gateway_System_OCP
{
    public class PayPalPayment : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing PayPal payment for amount: ${amount}");
        }
    }
}
