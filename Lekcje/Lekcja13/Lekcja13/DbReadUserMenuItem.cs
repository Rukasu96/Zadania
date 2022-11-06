using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja13
{
    public class DbReadUserMenuItem : MenuItem
    {
        public DbReadUserMenuItem() : base("Wczytaj uzytkownika")
        {
            Action = MyAction;
        }

        public void MyAction()
        {
            Console.WriteLine("Moja akcja rozbuodwana o baze danych");
        }
    }
}
