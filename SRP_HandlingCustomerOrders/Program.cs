using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_HandlingCustomerOrders
{
    //Testing the Single Responsibility Principle
    public class Program
    {
        public static void Main(string[] args)
        {
            Order newOrder = new Order();

            // Add items to the order
            List<OrderItem> Items = new List<OrderItem>()
            {
                new OrderItem(){ ProductItem = "Laptop", Price = 100000},
                new OrderItem(){ ProductItem = "Desktop", Price = 170000},
                new OrderItem(){ ProductItem = "Tab", Price = 100000},
            };
            newOrder.Items = Items;

            //set the customer...
            Customer customer = new Customer()
            {
                Name = "Umme",
                Email = "umme23@gmail.com"
            };
            newOrder.Customer = customer;

            ReceiptGenerator receiptGen = new ReceiptGenerator();
            string receipt = receiptGen.GenerateReceipt(newOrder);
            Console.WriteLine(receipt);

            CustomerNotifier notifier = new CustomerNotifier();
            notifier.NotifierCustomer(newOrder);

            Console.ReadKey();
        }
    }
}
