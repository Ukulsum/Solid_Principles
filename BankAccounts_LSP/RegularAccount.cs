using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts_LSP
{
    public class RegularAccount : BankAccount
    {
        public override void Withdraw(double amount)
        {
            if(balance >= amount)
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
