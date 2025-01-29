using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce__System_that_Provides_Discounts.OCP
{
    //Modify the DiscountCalculator class to accept an IDiscountStrategy
    public class DiscountCalculator
    {
        private readonly IDiscountStrategy _discountStrategy;
        public DiscountCalculator(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public double CalculateDiscount(double price)
        {
            return _discountStrategy.CalculateDiscount(price);
        } 
    }
}
