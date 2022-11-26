using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablicaOgloszen.MenuItems
{
    internal class Menu : MenuItem
    {
        private readonly List<MenuItem> menuItems;


        public Menu(string title) : base(title)
        {
            menuItems = new List<MenuItem>();
            Action = () => Run();
        }

        public void Add(MenuItem menuItem)
        {
            menuItems.Add(menuItem);
        }

        private void ShowMenu(List<MenuItem> options)
        {
            int opt = 1;
            options.ForEach(x => Console.WriteLine($"{opt++}. {x.Title}"));
            Console.WriteLine($"{opt}. Wyjście.");
        }

        public void Run()
        {
            int option = -1;
            var options = menuItems.Where(x => x.IsAvailable()).ToList();
            while (option != options.Count + 1)
            {
                options = menuItems.Where(x => x.IsAvailable()).ToList();
                ShowMenu(options);
                option = int.Parse(Console.ReadLine());
                if (option >= 1 && option <= options.Count)
                {
                    options[option - 1].Action?.Invoke();
                }
                else if (option == options.Count + 1)
                {
                    Console.WriteLine("Wyjscie");
                }
                else
                {
                    Console.WriteLine("Niepoprawna wartosc");
                }
            }
        }
    }
}
