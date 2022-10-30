using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using TablicaOgloszen;

User user = new User();

Console.WriteLine("[Zaloguj] [Zarejestruj]");
string option = Console.ReadLine();

switch (option)
{
    case "Zaloguj":
        user = Zaloguj();
        break;
    case "Zarejestruj":
        Zarejestruj();
        break;
    default:
        Console.WriteLine("Wpisz Zaloguj/Zarejestruj");
        break;
}


void DodajOgloszenie()
{
    Console.Clear();
    Console.WriteLine("Dodawanie Ogłoszenia");
    Console.WriteLine("Wpisz tytuł: ");
    string title = Console.ReadLine();
    Console.WriteLine("Wpisz tekst ogłoszenia:\n");
    string content = Console.ReadLine();

    bool correctPrice = false;
    string price = Console.ReadLine();
    do
    {
        Console.WriteLine("Podaj cene: ");
        price = Console.ReadLine();
        if(float.TryParse(price, out float n))
        {
            correctPrice = true;
        }
        else
        {
            Console.WriteLine("Niewłaściwa wartość");
        }

    } while (correctPrice == false);

    var ogloszenie = new Ogloszenie
    {
        Title = title,
        Text = content,
        Price = float.Parse(price),
        User = user
    };

    user.Ogloszenia.Add(ogloszenie);

    using (var context = new DataContext())
    {
        context.Ogloszenia.Add(ogloszenie);
        context.SaveChanges();
    }

    Console.Clear();
    Console.WriteLine("Ogłoszenie dodane pomyślnie");
    Menu();
}


void Menu()
{
    Console.Clear();
    Console.WriteLine("1.Dodaj ogłoszenie\n2.Przeglądaj ogłoszenia\n3.Sprawdź jakie przedmioty kupiłeś\n4.Wyloguj");
    Console.WriteLine();
    Console.WriteLine("Wpisz numer pozycji: ");
    option = Console.ReadLine();

    switch (option)
    {
        case "1":
            DodajOgloszenie();
            break;
        case "2":
            PrzegladajOgloszenia();
            break;
        case "3":
            PrzegladajKupioneProdukty();
            break;
        case "4":
            Console.WriteLine("Wylogowano");
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("Zły numer!");
            break;
    }
}


User Zaloguj()
{
    bool isCorrect = false;
    do
    {
        Console.WriteLine("Podaj nazwe użytkownika/email");
        string nameEmail = Console.ReadLine();
        Console.WriteLine("Podaj hasło:");
        string password = Console.ReadLine();

        var context = new DataContext();
        var user = context.Users.FirstOrDefault(x => x.Email == nameEmail || x.UserName == nameEmail);
        if (user == null)
        {
            Console.WriteLine("Niepoprawna nazwa użytkownika lub email");
        }
        else
        {
            if (user.Password == password)
            {
                isCorrect = true;
                Console.Clear();
                Console.WriteLine("Pomyślnie zalogowano");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Niepoprawne hasło!");
                Console.WriteLine();
            }
        }
    } while (isCorrect == false);

    Menu();
    return user;
}


void Zarejestruj()
{
    Console.WriteLine("Podaj nazwe uzytkownika");
    string username = Console.ReadLine();
    Console.WriteLine("Podaj email");
    string email = Console.ReadLine();
    Console.WriteLine("Podaj hasło:");
    string newPassword = Console.ReadLine();

    var newUser = new User
    {
        UserName = username,
        Email = email,
        Password = newPassword,
    };

    using (var newContext = new DataContext())
    {
        newContext.Users.Add(newUser);
        newContext.SaveChanges();
    }
    Console.Clear();
    Console.WriteLine("Zarejestrowano pomyślnie");
    Console.WriteLine("Czy chcesz się zalogować? Y/N");
    option = Console.ReadLine();
    if (option == "Y")
    {
        user = Zaloguj();
    }
    else if (option == "N")
    {
        Environment.Exit(1);
    }
}


void PrzegladajOgloszenia()
{
    Console.Clear();
    Console.WriteLine("Ogłoszenia");
    Console.WriteLine();
    
    int position = 0;

    using (var context = new DataContext())
    {
        var ogloszenia = context.Ogloszenia.Select(x => x.Title).ToList();
        ogloszenia.ForEach(x => Console.WriteLine($"{position++}.{x}"));
    }
    Console.WriteLine();
    Console.WriteLine("Wpisz numer ogłoszenia które chcesz przejrzeć: ");
    int option = int.Parse(Console.ReadLine());

    if(option <= position)
    {
        WyswietlOgloszenie(option);
    }
    else
    {
        Console.WriteLine("Nie ma takiej pozycji");
    }
}


void WyswietlOgloszenie(int option)
{
    Console.Clear();
    Ogloszenie ogloszenie;
    using (var context = new DataContext())
    {
        ogloszenie = context.Ogloszenia.FirstOrDefault(x => x.ID == option);
        Console.WriteLine($"{ogloszenie.Title}");
        Console.WriteLine();
        Console.WriteLine($"{ogloszenie.Text}");
        Console.WriteLine();
        Console.WriteLine($"{ogloszenie.Price}");
        Console.WriteLine();
    }
    Console.WriteLine("[Wstecz][Kup]");
    string input = Console.ReadLine();
    if(input == "Wstecz")
    {
        PrzegladajOgloszenia();
    }else if(input == "Kup")
    {
        KupProdukt(ogloszenie);
    }
    else
    {
        Console.WriteLine("Wpisz Wstecz/Kup");
    }

}


void KupProdukt(Ogloszenie ogloszenie)
{
    Console.Clear();
    Console.WriteLine("Gratulacje, dokonałeś zakupu.");

    user.Ogloszenia.Remove(ogloszenie);
    user.KupioneProdukty.Add(ogloszenie);

    using (var context = new DataContext())
    {
        context.Ogloszenia.Remove(ogloszenie);
    }

    Console.WriteLine("Naciśnij przycisk aby powrócić do menu.");
    Console.ReadKey();
    Menu();
}

void PrzegladajKupioneProdukty()
{
    Console.Clear();

    int position = 0;

    var ogloszenia = user.KupioneProdukty.Select(x => x.Title).ToList();
    ogloszenia.ForEach(x => Console.WriteLine($"{position++}.{x}"));

    Console.WriteLine();
    Console.WriteLine("Wpisz numer ogłoszenia które chcesz przejrzeć: ");
    int option = int.Parse(Console.ReadLine());

    if (option <= position)
    {
        Console.Clear();
        var ogloszenie = user.KupioneProdukty.FirstOrDefault(x => x.ID == option);
        Console.WriteLine($"{ogloszenie.Title}");
        Console.WriteLine();
        Console.WriteLine($"{ogloszenie.Text}");
        Console.WriteLine();
        Console.WriteLine($"{ogloszenie.Price}");
    }
    else
    {
        Console.WriteLine("Nie ma takiej pozycji");
    }

    Console.WriteLine();
    Console.WriteLine("Naciśnij przycisk aby powrócić do kupionych przedmiotów.");
    Console.ReadKey();
    PrzegladajKupioneProdukty();
}
