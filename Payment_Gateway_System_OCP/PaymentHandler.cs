using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Gateway_System_OCP
{
    //Modify the main payment handler
    public class PaymentHandler
    {
        private readonly IPaymentProcessor _paymentProcessor;
        public PaymentHandler(IPaymentProcessor paymentProcessor)
        {
            _paymentProcessor = paymentProcessor;
        }

        public void ExecutePayment(double amount)
        {
            _paymentProcessor.ProcessPayment(amount);
        }
    }
}
