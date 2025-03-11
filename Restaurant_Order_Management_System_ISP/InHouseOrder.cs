using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Order_Management_System_ISP
{
    public class InHouseOrder : IInHouseOrder
    {
        public void PrintTicket()
        {
            // Implementation for printing a ticket.
            Console.WriteLine("Printing Ticket");
        }
    }
}
