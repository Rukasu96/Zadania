using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablicaOgloszen.Data.Models;
using TablicaOgloszen.Repositories;

namespace TablicaOgloszen.MenuItems
{
    internal class DbSearchNotice : MenuItem
    {
        private readonly IAccountManager accountManager;
        private readonly IRepository repository;

        public DbSearchNotice(IAccountManager accountManager, IRepository repository) : base("Przegladaj ogłoszenia")
        {
            this.accountManager = accountManager;
            this.repository = repository;
            Action = PrzegladajOgloszenia;
        }

        public void PrzegladajOgloszenia()
        {
            Console.Clear();
            Console.WriteLine("Ogłoszenia");
            Console.WriteLine();

            int pos = 0;
            var ogloszenia = repository.GetAllOgloszenia();
            ogloszenia.ForEach(x => Console.WriteLine($"{++pos}. {x.Title}"));

            Console.WriteLine();
            Console.WriteLine("Wpisz numer ogłoszenia które chcesz przejrzeć: ");
            int option = int.Parse(Console.ReadLine());

            if (option >= 1 && option <= ogloszenia.Count)
            {
                WyswietlOgloszenie(ogloszenia[option - 1].ID);
            }
            else
            {
                Console.WriteLine("Nie ma takiej pozycji");
            }

        }

        void WyswietlOgloszenie(int option)
        {
            Console.Clear();
            Ogloszenie ogloszenie;

            ogloszenie = repository.FindOgloszenieById(option);
            Console.WriteLine($"{ogloszenie.Title}");
            Console.WriteLine();
            Console.WriteLine($"{ogloszenie.Text}");
            Console.WriteLine();
            Console.WriteLine($"{ogloszenie.Price}");
            Console.WriteLine();

            Menu menu = new Menu("Ogloszenia");
            menu.Add(new DbBuyProduct(accountManager, repository));
            menu.Run();
        }

        public override bool IsAvailable()
        {
            return accountManager.LoggedUser != null;
        }


    }
}
