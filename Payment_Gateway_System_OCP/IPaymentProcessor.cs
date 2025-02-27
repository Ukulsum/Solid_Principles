using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment_Gateway_System_OCP
{
    //Define an interface for processing payments
    public interface IPaymentProcessor
    {
        void ProcessPayment(double amount);
    }
}
