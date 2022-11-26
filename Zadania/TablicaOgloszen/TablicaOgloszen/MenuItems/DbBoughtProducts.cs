using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablicaOgloszen.Data.Models;
using TablicaOgloszen.Repositories;

namespace TablicaOgloszen.MenuItems
{
    internal class DbBoughtProducts : MenuItem
    {
        private readonly IAccountManager accountManager;

        public DbBoughtProducts(IAccountManager accountManager) : base("Przeglad kupionych produktów")
        {
            Action = PrzegladajKupioneProdukty;
            this.accountManager = accountManager;
        }

        private void PrzegladajKupioneProdukty()
        {
            Console.Clear();

            int position = 0;

            var ogloszenia = accountManager.LoggedUser.KupioneProdukty.Select(x => x.Title).ToList();
            ogloszenia.ForEach(x => Console.WriteLine($"{position++}.{x}"));

            Console.WriteLine();
            Console.WriteLine("Wpisz numer ogłoszenia które chcesz przejrzeć: ");
            int option = int.Parse(Console.ReadLine());

            if (option <= position)
            {
                Console.Clear();
                var ogloszenie = accountManager.LoggedUser.KupioneProdukty.FirstOrDefault(x => x.ID == option-1);
                Console.WriteLine($"{ogloszenie.Title}");
                Console.WriteLine();
                Console.WriteLine($"{ogloszenie.Text}");
                Console.WriteLine();
                Console.WriteLine($"{ogloszenie.Price}");
            }
            else
            {
                Console.WriteLine("Nie ma takiej pozycji");
            }

        }

        public override bool IsAvailable()
        {
            return accountManager.LoggedUser != null;
        }


    }


}
