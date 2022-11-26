using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablicaOgloszen.Data.Models;

namespace TablicaOgloszen.Repositories
{
    public class AccountManager : IAccountManager
    {
        public User LoggedUser { get; set; }
        public Ogloszenie SelectedOgloszenie { get; set; }
    }
}
