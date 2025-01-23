using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_HandlingCustomerOrders
{
    public class Order
    {
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Customer Customer { get; set; }

        public double CalculateOrderAmount()
        {
            return Items.Sum(i => i.Price);
        }
    }
}
