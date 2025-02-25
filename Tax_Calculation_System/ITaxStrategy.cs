using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax_Calculation_System
{
    //Define an interface for tax calculation
    public interface ITaxStrategy
    {
        double CalculateTax(Product product);
    }
}
