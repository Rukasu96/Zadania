using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablicaOgloszen
{
    internal class DbSearchNotice : MenuItem
    {
        private User user;
        public DbSearchNotice(User user) : base("Przegladaj ogłoszenia")
        {
            this.user = user;
            Action = PrzegladajOgloszenia;
        }

        public void PrzegladajOgloszenia()
        {
            Console.Clear();
            Console.WriteLine("Ogłoszenia");
            Console.WriteLine();

            using (var context = new DataContext())
            {
                int pos = 0;
                var ogloszenia = context.Ogloszenia.ToList();
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

        }

        void WyswietlOgloszenie(int option)
        {
            Console.Clear();
            Ogloszenie ogloszenie;
            using (var context = new DataContext())
            {
                ogloszenie = context.Ogloszenia.FirstOrDefault(x => x.ID == option);
                Console.WriteLine($"{ogloszenie.Title}");
                Console.WriteLine();
                Console.WriteLine($"{ogloszenie.Text}");
                Console.WriteLine();
                Console.WriteLine($"{ogloszenie.Price}");
                Console.WriteLine();
            }

            Menu menu = new Menu("Ogloszenia");
            menu.Add(new DbBuyProduct(user, ogloszenie));
            menu.Run();

        }


    }
}
