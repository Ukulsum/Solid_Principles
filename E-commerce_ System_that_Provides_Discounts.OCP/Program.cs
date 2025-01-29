using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce__System_that_Provides_Discounts.OCP
{
    //Testing the Open-Closed Principle
    public class Program
    {
        public static void Main(string[] args)
        {
            var regularDiscount = new RegularDiscount();
            var calculator = new DiscountCalculator(regularDiscount);
            double discountedPrice = calculator.CalculateDiscount(100); //10% discount applied

            var premiumDiscount = new RegularDiscount();
            calculator = new DiscountCalculator(premiumDiscount);
            discountedPrice = calculator.CalculateDiscount(100);    //30% discount applied

            Console.ReadKey();
        }
    }
}
