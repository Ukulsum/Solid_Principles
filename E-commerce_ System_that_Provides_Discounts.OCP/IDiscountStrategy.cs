using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce__System_that_Provides_Discounts.OCP
{
    //Create an interface for the discount strategy
    public interface IDiscountStrategy
    {
        double CalculateDiscount(double price);
    }
}
