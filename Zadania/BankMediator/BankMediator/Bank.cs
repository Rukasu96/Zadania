using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankMediator
{
    internal class Bank
    {
        private List<Account> accounts;

        public Bank()
        {
            accounts = new List<Account>();
        }

        public void Transfer(Account from, Account to, double amount)
        {
            from.Withdraw(amount);
            to.Deposit(amount);
            Console.WriteLine("Przelew wykonany pomyślnie");
        }

        public void AddAccount(Account acc)
        {
            accounts.Add(acc);
            acc.SetBank(this);
        }
    }
}
