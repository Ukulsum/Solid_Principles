using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts_LSP
{
    //Testing the Liskov Substitution Principle
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("RegularAccount:");
            var RegularBankAccount = new RegularAccount();
            RegularBankAccount.Deposite(1000);
            RegularBankAccount.Deposite(500);
            RegularBankAccount.Withdraw(900);
            RegularBankAccount.Withdraw(800);

            Console.WriteLine("\n FixedTermDepositAccount: ");
            var FixedTermDepositAccount = new FixedTermDepositAccount();
            FixedTermDepositAccount.Deposite(1000);
            FixedTermDepositAccount.Withdraw(500);


            Console.ReadKey();
        }
    }
}
