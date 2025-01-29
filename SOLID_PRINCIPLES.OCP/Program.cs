using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_PRINCIPLES.OCP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Invoice Amount: 10000");

            Invoice FInvoice = new FinalInvoice();
            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Final Invoice : {FInvoiceAmount}");


            Invoice pInvoice = new ProposedInvoice();
            double PInvoiceAmount = pInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Proposed Invoice : {PInvoiceAmount}") ;

            Invoice RInvoice = new RecurringInvoice();
            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);
            Console.WriteLine($"Recurring Invoice : {RInvoiceAmount}");

            Console.ReadKey();
        }
    }
}
