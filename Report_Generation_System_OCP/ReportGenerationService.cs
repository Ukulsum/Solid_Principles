using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report_Generation_System_OCP
{
    //Modify the main ReportGenerationService to work with any report generator
    public class ReportGenerationService
    {
        private readonly IReportGenerator _reportGenerator;
        public ReportGenerationService(IReportGenerator reportGenerator)
        {
            _reportGenerator = reportGenerator;
        }

        public void GenerateReport (string data)
        {
            _reportGenerator.GenerateReport (data);
        }
    }
}
