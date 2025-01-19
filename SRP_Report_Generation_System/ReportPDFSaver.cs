using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Report_Generation_System
{
    public class ReportPDFSaver
    {
        public void SaveAsPDF(string content, string filePath)
        {
            //PDF saving logic here
            Console.WriteLine($"Report Saved as PDF, content: {content} and Path: {filePath}");
        }
    }
}
