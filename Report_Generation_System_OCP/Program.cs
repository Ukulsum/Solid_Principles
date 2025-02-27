using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report_Generation_System_OCP
{
    //Testing the Open-Closed Principle
    public class Program
    {
        static void Main(string[] args)
        {
            var pdfGenerator = new PDFReportGenerator();
            var service = new ReportGenerationService(pdfGenerator);
            service.GenerateReport("PDF Report Data");

            var csvGenerator = new CSVReportGenerator();
            service = new ReportGenerationService(csvGenerator);
            service.GenerateReport("CSV Report Data");

            Console.ReadKey();
        }
    }
}
