using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablicaOgloszen.Data.Models;
using TablicaOgloszen.Repositories;

namespace TablicaOgloszen.MenuItems
{
    public class DbRegisterUsers : MenuItem
    {
        private readonly IAccountManager accountManager;
        private readonly IRepository repository;

        public DbRegisterUsers(IAccountManager accountManager, IRepository repository) : base("Zarejestruj")
        {
            Action = Zarejestruj;
            this.accountManager = accountManager;
            this.repository = repository;
        }

        private void Zarejestruj()
        {
            Console.WriteLine("Podaj nazwe uzytkownika");
            string username = Console.ReadLine();
            Console.WriteLine("Podaj email");
            string email = Console.ReadLine();
            Console.WriteLine("Podaj hasło:");
            string newPassword = Console.ReadLine();

            var newUser = new User
            {
                UserName = username,
                Email = email,
                Password = newPassword,
            };

            repository.Add(newUser);

            Console.Clear();
            Console.WriteLine("Zarejestrowano pomyślnie");
        }

        public override bool IsAvailable()
        {
            return accountManager.LoggedUser == null;
        }

    }
}
