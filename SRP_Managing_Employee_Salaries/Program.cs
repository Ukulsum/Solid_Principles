using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Managing_Employee_Salaries
{
    public class Program
    {
        public static void Main(string[] args)
        {
            EmployeeSalary umme = new EmployeeSalary
            {
                EmployeeName = "Umme Kulsum",
                BasicSalary = 5000,
                Bonus = 500
            };
            double totalSalary = umme.CalculateTotalSalary();

            SalaryDatabaseHandler dbHandler = new SalaryDatabaseHandler();
            dbHandler.SaveSalaryDetails(umme, totalSalary);
            Console.ReadKey();
        }
    }
}
