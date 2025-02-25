using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax_Calculation_System
{
    public class GroceriesTaxStrategy : ITaxStrategy
    {
        public double CalculateTax(Product product)
        {
            return product.Price * 0.05;
        }
    }
}
