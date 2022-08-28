//typy wartosciowe vs referencyjne
using lekcja8;

int a = 5;
int b = a;
a = 10;
Console.WriteLine(b);

Punkt p = new Punkt(5, 10);
Console.WriteLine(p);
Punkt p2 = p;
p.X = 100;

Console.WriteLine();
Console.WriteLine(p);
Console.WriteLine(p2);

//struct Adres
//ulica
//nr domu
//nr mieszkania

DateTime dt = DateTime.Now;
Console.WriteLine(dt);

Punkt? p3 = null;

Console.WriteLine(Mapa.srodek);
Console.WriteLine(Mapa.dodatkowy);