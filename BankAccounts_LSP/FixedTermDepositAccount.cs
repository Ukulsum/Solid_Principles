using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts_LSP
{
    public class FixedTermDepositAccount : BankAccount
    {
        private bool termEnded = false;    //Simplification for the example

        public override void Withdraw(double amount)
        {
            if (!termEnded)
            {
                Console.WriteLine("Cannot withdraw from a fixed term deposit account until term ends");
            }
            else if (balance >= amount) 
            {
                balance -= amount;
                Console.WriteLine($"Withdraw: {amount}, Balance: {balance}");
            }
            else
            {
                Console.WriteLine($"Trying to Withdraw: {amount}, Insufficient Funds, Available Funds: {balance}");
            }
        }
    }
}
