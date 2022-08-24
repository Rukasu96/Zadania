using Lekcja2;

void wykonajTure(IAtakujacy atakujacy, IObronca obronca)
{
    if(atakujacy == obronca)
    {
        return;
    }

    Console.WriteLine("Rozpoczyan rozgrywke:");
    Console.WriteLine(atakujacy);
    Console.WriteLine(obronca);
    atakujacy.Atakuj(obronca);
    Console.WriteLine("Koniec tury");
    Console.WriteLine();
}


Knight k = new Knight("Janusz", 15);
Druid d = new Druid("Tomasz");
Tower t = new Tower();

wykonajTure(k, t);
wykonajTure(k, d);
wykonajTure(t, k);
