using lekcja8_2;

Produkt p = new Produkt("Samsung", 1000, "Galaxy S10");
Console.WriteLine(p.Nazwa);
Console.WriteLine(p.Marka);
Console.WriteLine(p.Cena);
Console.WriteLine(p.CenaBrutto);
Console.WriteLine(p);

Punkt punkt = new Punkt(5, 8);
punkt.X = 15;