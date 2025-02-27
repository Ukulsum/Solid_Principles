using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Gateway_System_OCP
{
    //Testing the Open-Closed Principle
    public class Program
    {
        static void Main(string[] args)
        {
            var creditCardPayment = new CreditCardPayment();
            var handler = new PaymentHandler(creditCardPayment);
            handler.ExecutePayment(100.50);

            var paypalPayment = new PayPalPayment();
            handler = new PaymentHandler(paypalPayment);
            handler.ExecutePayment(150.75);

            Console.ReadKey();
        }
    }
}
