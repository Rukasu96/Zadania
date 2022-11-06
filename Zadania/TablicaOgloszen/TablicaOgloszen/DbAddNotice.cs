using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablicaOgloszen
{
    internal class DbAddNotice : MenuItem
    {
        private User user;
        public DbAddNotice(User user) : base("Dodaj ogłoszenie")
        {
            this.user = user;
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
                UserId = user.Id
            };

            using (var context = new DataContext())
            {
                context.Ogloszenia.Add(ogloszenie);
                context.SaveChanges();
            }

            Console.Clear();
            Console.WriteLine("Ogłoszenie dodane pomyślnie");
        }
    }
}
