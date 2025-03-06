using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles_and_Their_Engines_LSP
{
    public class ElectricVehicle : Vehicle
    {
        public override void StartEngine()
        {
            Console.WriteLine("Checking battery and starting electric motor.");
        }
    }
}
