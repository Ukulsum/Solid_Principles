using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Accounts_LSP
{
    //Testing the Liskov Substitution Principle
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount savingsAccount = new SavingsAccount("SA123", 1000m, 0.03m);
            BankAccount currentAccount = new CurrentAccount("CA456", 1500m, 500m);

            Console.WriteLine("Before Transactions:");
            //PrintAccountDetails(savingsAccount);
            //PrintAccountDetails(currentAccount);


        }
    }
}
