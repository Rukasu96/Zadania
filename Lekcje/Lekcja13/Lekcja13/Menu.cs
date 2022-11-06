using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja13
{
    public class Menu : MenuItem
    {
        private List<MenuItem> menuItems;

        public Menu(string title) : base(title)
        {
            menuItems = new List<MenuItem>();
            Action = () => Run();
        }

        public void Add(MenuItem menuItem)
        {
            menuItems.Add(menuItem);
        }

        private void ShowMenu()
        {
            int opt = 1;
            menuItems.ForEach(x => Console.WriteLine($"{opt++}. {x.Title}"));
            Console.WriteLine($"{opt}. Wyjście.");
        }

        public void Run()
        {
            int option = -1;
            while(option != menuItems.Count+1)
            {
                ShowMenu();
                option = int.Parse(Console.ReadLine());
                if(option >= 1 && option <= menuItems.Count)
                {
                    menuItems[option - 1].Action?.Invoke();
                }
                else if(option == menuItems.Count + 1)
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
