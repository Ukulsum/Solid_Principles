using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Managing_Employee_Salaries
{
    public class SalaryDatabaseHandler
    {
        public void SaveSalaryDetails(EmployeeSalary salary, double totalSalary)
        {
            //Logic to save salary details to a database
            Console.WriteLine($"Employee {salary.EmployeeName} Salary {totalSalary} Saved to DB");
        }
    }
}
