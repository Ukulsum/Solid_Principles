using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce__System_that_Provides_Discounts.OCP
{
    public class PremiumDiscount : IDiscountStrategy
    {
        public double CalculateDiscount(double price)
        {
            return price * 0.3;
        }
    }
}
