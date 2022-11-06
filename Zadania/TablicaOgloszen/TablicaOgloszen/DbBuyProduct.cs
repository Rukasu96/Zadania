using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablicaOgloszen
{
    internal class DbBuyProduct : MenuItem
    {
        private User user;
        private Ogloszenie ogloszenie;
        public DbBuyProduct(User user, Ogloszenie ogloszenie) : base("Kup produkt")
        {
            this.user = user;
            this.ogloszenie = ogloszenie;
            Action = KupProdukt;
        }

        public void KupProdukt()
        {
            Console.Clear();
            var newBuyProduct = new KupioneOgloszenia
            {
                Title = ogloszenie.Title,
                Text = ogloszenie.Text,
                Price = ogloszenie.Price,
                User = user
            };

            Console.WriteLine("Gratulacje, dokonałeś zakupu.");

            user.Ogloszenia.Remove(ogloszenie);
            user.KupioneProdukty.Add(newBuyProduct);
            
            using (var context = new DataContext())
            {
                context.Ogloszenia.Remove(ogloszenie);
                context.KupioneProdukty.Add(newBuyProduct);
                context.SaveChanges();
            }

            
        }
    }
}
