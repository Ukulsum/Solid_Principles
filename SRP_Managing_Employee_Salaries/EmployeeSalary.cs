using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Managing_Employee_Salaries
{
    public class EmployeeSalary
    {
        public string EmployeeName { get; set; }
        public double BasicSalary { get; set; }
        public double Bonus {  get; set; }


        public double CalculateTotalSalary()
        {
            return BasicSalary + Bonus;
        }
    }
}
