using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMediator
{
    internal class Account
    {
        private string name;
        private string surname;
        private string accountNumb;
        private double amount;
        private Bank bank;

        public Account(string name, string surname, string accountNumb, double amount)
        {
            this.name = name;
            this.surname = surname;
            this.accountNumb = accountNumb;
            this.amount = amount;
        }

        public void Withdraw(double amount)
        {
            this.amount -= amount;
            Console.WriteLine($"Konto: {accountNumb}, wypłaciło: {amount}, stan konta: {this.amount}");
        }

        public void Deposit(double amount)
        {
            this.amount += amount;
            Console.WriteLine($"Konto: {accountNumb}, otrzymało: {amount}, stan konta: {this.amount}");
        }

        public void Transfer(Account to, double amount)
        {
            bank.Transfer(this, to, amount);
        }

        public void SetBank(Bank bank)
        {
            this.bank = bank;
        }
    }
}
