using Lekcja5;
using System.Text.Json;

void Kalkulator(int a, int b, Func<int, int, int> funkcja)
{
    Console.WriteLine("Wykonuje obliczenia:");
    Console.WriteLine($"Wynik: " + funkcja(a, b));
}

Kalkulator(5, 1, (a, b) => a + b);

//delegate int Operacja(int a, int b);
//void Kalkulator(int a, int b, Operacja funkcja)
//{
//    Console.WriteLine("Wykonuje obliczenia:");
//    Console.WriteLine($"Wynik: " + funkcja(a, b));
//}
//Podmien(napis, x => x == 'a' ? 'o' : x);


HttpClient client = new HttpClient();
string text = client.GetAsync("https://www.cheapshark.com/api/1.0/deals?storeID=1&upperPrice=1000").Result.Content.ReadAsStringAsync().Result;
var games = JsonSerializer.Deserialize<List<Game>>(text);

var gamesA = games.Where(x => x.title.StartsWith("A") && float.Parse(x.salePrice.Replace(".", ",")) < 50).ToList();
foreach(var game in gamesA)
{
    Console.WriteLine($"{game.title} {game.salePrice}");
}

var firstBestGame = games.First(game => game.steamRatingText == "Mostly Positive"); //First - wyjatek jesli elementu nie ma
Console.WriteLine($"{firstBestGame.title} {firstBestGame.steamRatingText}");

var firstBestGame2 = games.FirstOrDefault(game => game.steamRatingText == "MostlyPositive"); //Zwraca null jesli nie ma elementu
Console.WriteLine(firstBestGame2);

int bestGamesCount = games.Count(game => game.steamRatingText == "Mostly Positive");
Console.WriteLine(bestGamesCount);
Console.WriteLine();

games = games.OrderByDescending(x => x.salePrice).ThenBy(x => x.title).ToList();
games.ForEach(x => Console.WriteLine(x));

var mostlyPositivePrice = games.Where(x => x.steamRatingText == "Mostly Positive").Sum(x => x.SalePrice);
Console.WriteLine(mostlyPositivePrice);

var cheapTop3 = games.OrderBy(x => x.salePrice).Take(3).ToList();
Console.WriteLine("Cheap:");
cheapTop3.ForEach(x => Console.WriteLine(x));

if(games.Any(x => x.SalePrice > 10))
{
    Console.WriteLine("Tak jest gra drozsza niz 10$");
}

var groups = games.GroupBy(x => x.steamRatingText).ToList();
foreach(var g in groups)
{
    Console.WriteLine("Ocena: " + g.Key);
    foreach(var game in g)
    {
        Console.WriteLine(game);
    }
}

string rating(float price)
{
    if(price < 3)
    {
        return "cheap";
    }
    else if(price < 8)
    {
        return "medium";
    }
    else
    {
        return "expensive";
    }
}

groups = games.GroupBy(x => rating(x.SalePrice)).ToList();
foreach (var g in groups)
{
    Console.WriteLine("Ocena: " + g.Key);
    foreach (var game in g.Take(3))
    {
        Console.WriteLine(game);
    }
}

DateTime now = DateTime.Now;
Console.WriteLine(now);
Console.WriteLine(now.Year);
Console.WriteLine(now.Month);
Console.WriteLine(now.Day);

DateTime day = new DateTime(2022, 5, 15);
Console.WriteLine(day);

DateTime? dataUrodzin = null;
dataUrodzin = new DateTime();
Console.WriteLine(dataUrodzin);

int? value = null;
Console.WriteLine(value);

var titles = games.Select(x => x.title).ToList();
titles.ForEach(x => Console.WriteLine(x));

var offers = games.Select(x => new Offer { Price = x.SalePrice, Title = x.title }).ToList();
Console.WriteLine();