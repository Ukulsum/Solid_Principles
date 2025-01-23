using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_HandlingCustomerOrders
{
    public class ReceiptGenerator
    {
        public string GenerateReceipt(Order order)
        {
            // Logic to generate a receipt based on the given order
            return $"Receipt for {order.Customer.Name} : Total - {order.CalculateOrderAmount()}";
        }
    }
}
