using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablicaOgloszen
{
    internal class DbBoughtProducts : MenuItem
    {
        private User user;
        public DbBoughtProducts(User user) : base("Przeglad kupionych produktów")
        {
            this.user = user;
            Action = PrzegladajKupioneProdukty;
        }

        private void PrzegladajKupioneProdukty()
        {
            Console.Clear();

            int position = 0;

            var ogloszenia = user.KupioneProdukty.Select(x => x.Title).ToList();
            ogloszenia.ForEach(x => Console.WriteLine($"{position++}.{x}"));

            Console.WriteLine();
            Console.WriteLine("Wpisz numer ogłoszenia które chcesz przejrzeć: ");
            int option = int.Parse(Console.ReadLine());

            if (option <= position)
            {
                Console.Clear();
                var ogloszenie = user.KupioneProdukty.FirstOrDefault(x => x.ID == option);
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


    }

    
}
