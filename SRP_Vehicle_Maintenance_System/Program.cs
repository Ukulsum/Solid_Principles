using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Vehicle_Maintenance_System
{
    //Testing the Single Responsibility Principle
    public class Program
    {
        public static void Main(string[] args)
        {
            Vehicle myCar = new Vehicle { VIN = "abc123", Model = "Model S", LastServiceDate = DateTime.Now.AddMonths(-13) };

            MaintenanceLog maintenance = new MaintenanceLog(myCar);
            maintenance.LogMantenance("Replaced breke pads");

            ServiceAlertHandler alertHandler = new ServiceAlertHandler(myCar);
            if (alertHandler.IsServiceDue())
            {
                alertHandler.SendServiceAlert();
            }
            Console.ReadKey();
        }
    }
}
