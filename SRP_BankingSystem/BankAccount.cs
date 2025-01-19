using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_BankingSystem
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public double Balance { get; private set; }
        public List<string> Transactions = new List<string>();

        public BankAccount(int accountNumber)
        {
            AccountNumber = accountNumber;
        }

        public void Deposite(double amount) 
        {
            Balance += amount;
            Transactions.Add($"Deposited ${amount}. New Balance: ${Balance}");
        }

        public void Withdraw(double amount)
        {
            Balance -= amount;
            Transactions.Add($"Withdrew ${amount}. New Balance: ${Balance}");
        }
    }
}
