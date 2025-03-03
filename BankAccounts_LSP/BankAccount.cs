using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts_LSP
{
    public abstract class BankAccount
    {
        protected double balance;

        public virtual void Deposite(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposit: {amount}, Total Amount: {balance}");
        }

        public abstract void Withdraw (double amount);

        public double GetBalance()
        {
            return balance;
        }
    }
}
