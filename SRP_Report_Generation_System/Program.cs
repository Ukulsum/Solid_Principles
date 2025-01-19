using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Report_Generation_System
{
    //Testing the Single Responsibility Principle
    public class Program
    {
        public static void Main(string[] args)
        {
            Employee umme = new Employee { Name = "Umme", HoursWorked = 160, Pay = 5000 };
            EmployeeReport report = new EmployeeReport(umme);
            string content = report.GenerateReportContent();

            ReportPrinter printer = new ReportPrinter();
            printer.Print(content);

            ReportPDFSaver pdfSaver = new ReportPDFSaver();
            pdfSaver.SaveAsPDF(content, "path_to_save_report.pdf");
            Console.ReadKey();
        }
    }
}
