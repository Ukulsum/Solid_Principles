using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES.OCP
{
    public class Invoice
    {
        public virtual double GetInvoiceDiscount(double amount)
        {
            return amount - 50;
        }
    }
}
