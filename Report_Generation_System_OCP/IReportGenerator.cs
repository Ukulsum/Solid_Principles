using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report_Generation_System_OCP
{
    //Define an interface for report generation
    public interface IReportGenerator
    {
        void GenerateReport(string data);
    }
}
