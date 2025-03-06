using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles_and_Their_Engines_LSP
{
    //Testing the Liskov Substitution Principle
    public class Program
    {
        public static void Main(string[] args)
        {
            Vehicle vehicle = new GasolineVehicle();
            vehicle.StartEngine();

            vehicle = new ElectricVehicle();
            vehicle.StartEngine();

            Console.ReadKey();
        }
    }
}
