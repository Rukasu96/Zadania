using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablicaOgloszen.Data.Models;

namespace TablicaOgloszen.Repositories
{
    public interface IRepository
    {
        void Add(User user);
        void Add(Ogloszenie ogloszenie);
        void Add(KupioneOgloszenia kupioneOgloszenia);
        List<KupioneOgloszenia> GetAllKupione();
        List<Ogloszenie> GetAllOgloszenia();
        void BuyProduct(Ogloszenie ogl, KupioneOgloszenia kupioneOgloszenia);
        User FindUserByNameOrEmail(string name);
        Ogloszenie FindOgloszenieById(int id);
    }
}
