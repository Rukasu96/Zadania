using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TablicaOgloszen.Data.Models;

namespace TablicaOgloszen.Repositories
{
    public interface IAccountManager
    {
        User LoggedUser { get; set; }
        Ogloszenie SelectedOgloszenie { get; set; }
    }
}
