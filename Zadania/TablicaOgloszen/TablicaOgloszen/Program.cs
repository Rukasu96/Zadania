using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using TablicaOgloszen.Data;
using TablicaOgloszen.MenuItems;
using TablicaOgloszen.Repositories;

Menu menu = new Menu("Panel logowania");
DataContext context = new DataContext();
IRepository repository = new DbRepository(context);
IAccountManager accountManager = new AccountManager();

menu.Add(new DbReadUsers(accountManager, repository));
menu.Add(new DbRegisterUsers(accountManager, repository));
menu.Add(new DbAddNotice(accountManager, repository));
menu.Add(new DbSearchNotice(accountManager, repository));
menu.Add(new DbBoughtProducts(accountManager));
menu.Run();

context.Dispose();





