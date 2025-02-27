using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report_Generation_System_OCP
{
    //Implement this interface for each report type
    public class PDFReportGenerator : IReportGenerator
    {
        public void GenerateReport(string data)
        {
            Console.WriteLine($"Generating PDF report with data: {data}");
        }
    }
}
