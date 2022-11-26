using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablicaOgloszen.Data.Models;
using TablicaOgloszen.Repositories;

namespace TablicaOgloszen.MenuItems
{
    internal class DbBuyProduct : MenuItem
    {
        private readonly IAccountManager accountManager;
        private readonly IRepository repository;

        public DbBuyProduct(IAccountManager accountManager, IRepository repository) : base("Kup produkt")
        {
            this.accountManager = accountManager;
            this.repository = repository;
            Action = KupProdukt;
        }

        public void KupProdukt()
        {
            Console.Clear();
            var ogloszenie = accountManager.SelectedOgloszenie;
            accountManager.SelectedOgloszenie = null;

            var newBuyProduct = new KupioneOgloszenia
            {
                Title = ogloszenie.Title,
                Text = ogloszenie.Text,
                Price = ogloszenie.Price,
                User = accountManager.LoggedUser
            };
            repository.BuyProduct(ogloszenie, newBuyProduct);
            Console.WriteLine("Gratulacje, dokonałeś zakupu.");
        }

        public override bool IsAvailable()
        {
            return accountManager.LoggedUser != null && accountManager.SelectedOgloszenie != null;
        }
    }
}
