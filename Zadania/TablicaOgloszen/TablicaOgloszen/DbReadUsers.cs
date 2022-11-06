using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablicaOgloszen
{
    internal class DbReadUsers : MenuItem
    {

        public DbReadUsers() : base("Zaloguj")
        {
            Action = Zaloguj;
        }
        

        public void Zaloguj()
        {
            bool isCorrect = false;
            User user = null;
            Menu menu = new Menu("Panel użytkownika");
            do
            {
                Console.WriteLine("Podaj nazwe użytkownika/email");
                string nameEmail = Console.ReadLine();
                Console.WriteLine("Podaj hasło:");
                string password = Console.ReadLine();

                var context = new DataContext();
                user = context.Users.FirstOrDefault(x => x.Email == nameEmail || x.UserName == nameEmail);
                if (user == null)
                {
                    Console.WriteLine("Niepoprawna nazwa użytkownika lub email");
                }
                else
                {
                    if (user.Password == password)
                    {
                        isCorrect = true;
                        Console.Clear();
                        Console.WriteLine("Pomyślnie zalogowano");
                        menu.Add(new DbAddNotice(user));
                        menu.Add(new DbSearchNotice(user));
                        menu.Add(new DbBoughtProducts(user));
                        menu.Run();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Niepoprawne hasło!");
                        Console.WriteLine();
                    }
                }
            } while (isCorrect == false);

            

        }
    }
}
