using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablicaOgloszen
{
    public class DbRegisterUsers : MenuItem
    {
        public DbRegisterUsers() : base("Zarejestruj")
        {
            Action = Zarejestruj;
        }

        private void Zarejestruj()
        {
            Console.WriteLine("Podaj nazwe uzytkownika");
            string username = Console.ReadLine();
            Console.WriteLine("Podaj email");
            string email = Console.ReadLine();
            Console.WriteLine("Podaj hasło:");
            string newPassword = Console.ReadLine();

            var newUser = new User
            {
                UserName = username,
                Email = email,
                Password = newPassword,
            };

            using (var newContext = new DataContext())
            {
                newContext.Users.Add(newUser);
                newContext.SaveChanges();
            }
            Console.Clear();
            Console.WriteLine("Zarejestrowano pomyślnie");
        }
       
    }
}
