using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablicaOgloszen.Data.Models;
using TablicaOgloszen.Repositories;

namespace TablicaOgloszen.MenuItems
{
    internal class DbAddNotice : MenuItem
    {
        private readonly IAccountManager accountManager;
        private readonly IRepository repository;

        public DbAddNotice(IAccountManager accountManager, IRepository repository) : base("Dodaj ogłoszenie")
        {
            this.accountManager = accountManager;
            this.repository = repository;
            Action = DodajOgloszenie;
        }

        public void DodajOgloszenie()
        {
            Console.Clear();
            Console.WriteLine("Dodawanie Ogłoszenia");
            Console.WriteLine("Wpisz tytuł: ");
            string title = Console.ReadLine();
            Console.WriteLine("Wpisz tekst ogłoszenia:");
            string content = Console.ReadLine();

            bool correctPrice = false;
            string price;
            do
            {
                Console.WriteLine("Podaj cene: ");
                price = Console.ReadLine();
                if (float.TryParse(price, out float n))
                {
                    correctPrice = true;
                }
                else
                {
                    Console.WriteLine("Niewłaściwa wartość");
                }

            } while (correctPrice == false);

            var ogloszenie = new Ogloszenie
            {
                Title = title,
                Text = content,
                Price = float.Parse(price),
                UserId = accountManager.LoggedUser.Id
            };

            repository.Add(ogloszenie);

            Console.Clear();
            Console.WriteLine("Ogłoszenie dodane pomyślnie");
        }

        public override bool IsAvailable()
        {
            return accountManager.LoggedUser != null;
        }
    }
}
