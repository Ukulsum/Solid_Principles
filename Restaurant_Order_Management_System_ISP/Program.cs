using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Order_Management_System_ISP
{
    //Testing the Interface Segregation Principle
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("OnlineOrder:");
            OnlineOrder onlineOrder = new OnlineOrder();
            onlineOrder.ProcessOnlinePayment();
            onlineOrder.GenerateReceipt();

            Console.WriteLine("\nInHouseOrder:");
            InHouseOrder inHouseOrder = new InHouseOrder();
            inHouseOrder.PrintTicket();

            Console.WriteLine("\nPhoneOrder:");
            PhoneOrder phoneOrder = new PhoneOrder();
            phoneOrder.ConfirmOverPhone();

            Console.ReadKey();
        }
    }
}
