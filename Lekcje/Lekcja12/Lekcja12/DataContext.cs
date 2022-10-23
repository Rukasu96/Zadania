using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja12
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=UsersDB;Trusted_Connection=True;");
        }
       
        public DbSet<User> Users { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterType> CharacterTypes { get; set; }
    }
}

//wejdz w package manager console
//sprawdz czy jestes w dobrym folderze: ls
//jesli nie jestesmy do przedz do kolejnego katalogu: cd Lekcja12
//jesli uzywasz na nowym komputerze to uzyj komendy: dotnet tool install --global dotnet-ef
//utworz migracje:  dotnet ef migrations add "nazwa migracji tutaj"
//dodaj zmiany na serwer: dotnet ef database update