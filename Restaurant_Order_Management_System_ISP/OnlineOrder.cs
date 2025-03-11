using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Order_Management_System_ISP
{
    // Implementing segregated interfaces
    public class OnlineOrder : IOnlineOrder
    {
        public void GenerateReceipt()
        {
            // Implementation for processing online payment.
            Console.WriteLine("Processing Online Payment");
        }

        public void ProcessOnlinePayment()
        { 
            // Implementation for generating a receipt.
            Console.WriteLine("Generating Receipt");
        }
    }
}
