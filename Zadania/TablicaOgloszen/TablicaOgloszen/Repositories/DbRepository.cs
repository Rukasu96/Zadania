using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablicaOgloszen.Data;
using TablicaOgloszen.Data.Models;

namespace TablicaOgloszen.Repositories
{
    public class DbRepository : IRepository
    {
        private readonly DataContext context;

        public DbRepository(DataContext context)
        {
            this.context = context;
        }
        public void Add(User user)
        {
            context.Add(user);
            context.SaveChanges();
        }

        public void Add(Ogloszenie ogloszenie)
        {
            context.Add(ogloszenie);
            context.SaveChanges();
        }

        public void Add(KupioneOgloszenia kupioneOgloszenia)
        {
            context.Add(kupioneOgloszenia);
            context.SaveChanges();
        }

        public void BuyProduct(Ogloszenie ogl, KupioneOgloszenia kupioneOgloszenia)
        {
            context.Ogloszenia.Remove(ogl);
            context.KupioneProdukty.Add(kupioneOgloszenia);
            context.SaveChanges();
        }

        public Ogloszenie FindOgloszenieById(int id)
        {
            return context.Ogloszenia.FirstOrDefault(x => x.ID == id);
        }

        public User FindUserByNameOrEmail(string name)
        {
            return context.Users.FirstOrDefault(x => x.Email == name || x.UserName == name);
        }

        public List<KupioneOgloszenia> GetAllKupione()
        {
            return context.KupioneProdukty.ToList();
        }

        public List<Ogloszenie> GetAllOgloszenia()
        {
            return context.Ogloszenia.ToList();
        }
    }
}
