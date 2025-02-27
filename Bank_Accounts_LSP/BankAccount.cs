using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Accounts_LSP
{
    //Imagine you have a base class BankAccount
    public class BankAccount
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accountNumber, decimal balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposit : {amount}, Total Amount : {Balance}");
        }

        public virtual void Withdraw (decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
    }
}
