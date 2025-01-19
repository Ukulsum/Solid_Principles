using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_BankingSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BankAccount ummesAccount = new BankAccount(12542);
            ummesAccount.Deposite(500);
            ummesAccount.Withdraw(100);

            StatementPrinter printer = new StatementPrinter();
            printer.Print(ummesAccount);
            Console.ReadKey();
        }
    }
}
