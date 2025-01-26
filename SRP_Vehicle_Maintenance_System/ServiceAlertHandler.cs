using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Vehicle_Maintenance_System
{
    public class ServiceAlertHandler
    {
        private Vehicle _vehicle;

        public ServiceAlertHandler(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public bool IsServiceDue()
        {
            // Logic to determine if the vehicle is due for service
            return (DateTime.Now - _vehicle.LastServiceDate).TotalDays > 365;
        }

        public void SendServiceAlert()
        {
            if(IsServiceDue())
            {
                // Logic to send a service alert to the vehicle owner
                Console.WriteLine("Service Alert Send to Customer");
            }
        }
    }
}
