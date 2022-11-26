using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablicaOgloszen.Data.Models;
using TablicaOgloszen.Repositories;

namespace TablicaOgloszen.MenuItems
{
    internal class DbReadUsers : MenuItem
    {
        private readonly IAccountManager accountManager;
        private readonly IRepository repository;

        public DbReadUsers(IAccountManager accountManager, IRepository repository) : base("Zaloguj")
        {
            Action = Zaloguj;
            this.accountManager = accountManager;
            this.repository = repository;
        }


        public void Zaloguj()
        {
            Console.WriteLine("Podaj nazwe użytkownika/email");
            string nameEmail = Console.ReadLine();
            Console.WriteLine("Podaj hasło:");
            string password = Console.ReadLine();

            var user = accountManager.LoggedUser = repository.FindUserByNameOrEmail(nameEmail);

            if (user == null)
            {
                Console.WriteLine("Niepoprawna nazwa użytkownika lub email");
            }
            else
            {
                if (user.Password == password)
                {
                    accountManager.LoggedUser = user;
                    Console.Clear();
                    Console.WriteLine("Pomyślnie zalogowano");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Niepoprawne hasło!");
                    Console.WriteLine();
                }
            }
        }

        public override bool IsAvailable()
        {
            return accountManager.LoggedUser == null;
        }
    }
}
