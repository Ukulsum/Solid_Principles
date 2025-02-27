using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Gateway_System_OCP
{
    //Implement this interface for each payment method
    public class CreditCardPayment : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing credit card payment for amount: ${amount}");
        }
    }
}
