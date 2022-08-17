
Dictionary<string,int> liczby = new Dictionary<string,int>();

string liczba = Console.ReadLine();
liczby.Add("jeden", 1);
liczby.Add("dwa", 2);
liczby.Add("trzy", 3);
liczby.Add("cztery", 4);
liczby.Add("pięć", 5);

Zamien(liczba);

void Zamien(string liczba)
{
    var liczbaInt = liczby.First(x => x.Key == liczba);
    Console.WriteLine($"Wynik: {liczbaInt.Value}"); 

}
