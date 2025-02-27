using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Accounts_LSP
{
    //We have two derived classes: SavingsAccount and CurrentAccount
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; set; }
        public SavingsAccount(string accountNumber, decimal balance, decimal interestRate) : base(accountNumber, balance)
        {
            InterestRate = interestRate;
        }

        public override void Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"AccountNumber: {AccountNumber}, Withdraw: {amount}, Balance: {Balance}");
            }
            else
            {
                Console.WriteLine($"AccountNumber: {AccountNumber}, Withdraw: {amount}, Insufficient Funds, Available Funds: {Balance}");
            }
        }
    }
}
