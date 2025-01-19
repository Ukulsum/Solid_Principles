using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Report_Generation_System
{
    public class ReportPrinter
    {
        public void Print(string content)
        {
            //print logic here
            Console.WriteLine($"Report Printed: {content}");
        }
    }
}
