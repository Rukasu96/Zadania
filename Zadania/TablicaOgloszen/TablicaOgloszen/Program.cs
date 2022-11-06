using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using TablicaOgloszen;

Menu menu = new Menu("Panel logowania");
menu.Add(new DbReadUsers());
menu.Add(new DbRegisterUsers());
menu.Run();





