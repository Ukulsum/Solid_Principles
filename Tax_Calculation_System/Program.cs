using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tax_Calculation_System;

namespace Tax_Calculation_System_OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var electronicsProduct = new Product
            {
                Name = "Laptop",
                Price = 1000,
                Category = ProductCategory.Electronics
            };
            var taxCalculator = new TaxCalculator(new ElectronicsTaxStrategy());
            Console.WriteLine($"Tax for  {electronicsProduct.Name} ${taxCalculator.CalculateTax(electronicsProduct)}");

            Console.ReadKey();
        }
    }
}
