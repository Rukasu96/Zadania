using Lekcja12;
using System.Security.Cryptography;

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
        var user = context.Users.FirstOrDefault(x => x.Email == email);
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
                var characters = context.Characters.Where(x => x.User.Id == user.Id).ToList();
                characters.ForEach(x => Console.WriteLine(x.Name));
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
