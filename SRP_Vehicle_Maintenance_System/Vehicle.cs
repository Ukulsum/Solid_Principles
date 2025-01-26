using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Vehicle_Maintenance_System
{
    public class Vehicle
    {
        public string VIN { get; set; }
        public string Model { get; set; }
        public DateTime LastServiceDate { get; set; }
    }
}
