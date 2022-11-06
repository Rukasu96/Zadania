using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TablicaOgloszen
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=UsersBoardsDB;Trusted_Connection=True;");
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Ogloszenie> Ogloszenia { get; set; }
        public DbSet<KupioneOgloszenia> KupioneProdukty { get; set; }

    }
}
