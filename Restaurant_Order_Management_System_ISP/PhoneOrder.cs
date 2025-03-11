using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Order_Management_System_ISP
{
    public class PhoneOrder : IPhoneOrder
    {
        public void ConfirmOverPhone()
        {
            // Implementation to confirm order over the phone.
            // Implementation for printing a ticket.
            Console.WriteLine("Confirming order over the phone");
        }
    }
}
