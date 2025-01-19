using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Report_Generation_System
{
    public class EmployeeReport
    {
        private Employee _employee;

        public EmployeeReport(Employee employee)
        {
            _employee = employee;
        }

        public string GenerateReportContent()
        {
            return $"Employee: {_employee.Name}, Hours: {_employee.HoursWorked}, Pay: {_employee.Pay}";
        }
    }
}
