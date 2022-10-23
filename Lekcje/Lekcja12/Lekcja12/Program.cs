using Lekcja12;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

using (var context = new DataContext())
{
    var characters = context.Characters
        .Include(x => x.User)
        .Include(x => x.Types)
        .Where(x => x.Lvl > 10)
        .ToList();

    characters.ForEach(x => Console.WriteLine(x.Name + " " + x.User.Email + " types: " + string.Join(", ", x.Types.Select(x => x.Name))));

    //var type = context.CharacterTypes.FirstOrDefault(x => x.Key == 1);
    //characters[0].Types.Add(type);
    //context.SaveChanges();
}

Console.WriteLine();
Console.WriteLine("[zaloguj][zarejestruj]");
string option = Console.ReadLine();

if(option == "zaloguj")
{
    Console.WriteLine("Podaj email");
    string email = Console.ReadLine();
    Console.WriteLine("Podaj hasło:");
    string password = Console.ReadLine();
    using (var context = new DataContext())
    {
        var user = context.Users.Include(x => x.Characters).FirstOrDefault(x => x.Email == email);
        if(user == null)
        {
            Console.WriteLine("Niepoprawne dane logowania");
        }
        else
        {
            HMACSHA512 hmac = new HMACSHA512(user.PasswordSalt);
            byte[] passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            if(passwordHash.SequenceEqual(user.PasswordHash))
            {
                Console.WriteLine($"Zalogowano! data rejestracji: {user.DateCreated}");
                //var characters = context.Characters.Where(x => x.User.Id == user.Id).ToList();
                //characters.ForEach(x => Console.WriteLine(x.Name));
                user.Characters.ForEach(x => Console.WriteLine(x.Name));
            }
            else
            {
                Console.WriteLine("Niepoprawne hasło!");
            }
        }
    }
}
else if(option == "zarejestruj")
{
    Console.WriteLine("Podaj nazwe uzytkownika");
    string username = Console.ReadLine();
    Console.WriteLine("Podaj email");
    string email = Console.ReadLine();
    Console.WriteLine("Podaj hasło:");
    string password = Console.ReadLine();

    HMACSHA512 hmac = new HMACSHA512();
    var user = new User
    {
        Username = username,
        Email = email,
        PasswordSalt = hmac.Key,
        PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password))
    };
    using (var context = new DataContext())
    {
        context.Users.Add(user);
        context.SaveChanges();
    }
}

//tablica ogloszen
//rejestracja i logowanie uzytkownikow
//mozliwosc dodania ogloszenia
//mozliowsc przegladania ogloszen i kupna
//mozliwosc sprawdzenia ktore przedmioty kupil uzytkownik
