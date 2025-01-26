using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Vehicle_Maintenance_System
{
    public class MaintenanceLog
    {
        private Vehicle _vehicle;

        public MaintenanceLog(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public void LogMantenance(string details)
        {
            // Logic to log maintenance details for the given vehicle
            Console.WriteLine(details);
        }
    }
}
