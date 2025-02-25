using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax_Calculation_System
{
    public class TaxCalculator
    {
        private ITaxStrategy _taxStrategy;
        public TaxCalculator(ITaxStrategy taxStrategy)
        {
            _taxStrategy = taxStrategy;
        }

        public double CalculateTax(Product product)
        {
            return _taxStrategy.CalculateTax(product);
        }
    }
}
