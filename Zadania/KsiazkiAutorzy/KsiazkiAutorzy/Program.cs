﻿using KsiazkiAutorzy;

Katalog katalog = new Katalog();

Ksiazka k1 = new Ksiazka("Harry Potter", 1, "Media Rodzina", 2000, 350);
Ksiazka k2 = new Ksiazka("Metro 2033", 2, "Ignis", 2005, 200);
Ksiazka k3 = new Ksiazka("Warcraft", 3, "ISA", 2003, 300);

Czasopismo cz1 = new Czasopismo("Cebador", 4, "Ogien", 1999, 25);
Czasopismo cz2 = new Czasopismo("Cerber", 5, "Dog", 2010, 1);

k1.DodajAutora(new Autor("J.K", "Rowling", "USA"));
k2.DodajAutora(new Autor("Dmitrij", "Głuchowski", "Rosja"));
k3.DodajAutora(new Autor("Richard", "Knaak", "Polska"));
k3.DodajAutora(new Autor("Christie", "Golden", "USA"));

katalog.DodajPozycje(k1);
katalog.DodajPozycje(k2);
katalog.DodajPozycje(k3);
katalog.DodajPozycje(cz1);
katalog.DodajPozycje(cz2);

katalog.WypiszWszystkiePozycje();
//katalog.ZnajdzPozycje("Harry", "Ignis");
Console.WriteLine();

bool ByISA(Pozycja p)
{
    return p.Wydawnictwo == "ISA";
}

Pozycja p = katalog.ZnajdzPozycje2(ByISA);
p.WypiszInfo();

Pozycja p2 = katalog.ZnajdzPozycje2(poz => poz.RokWydania == 2000);
p2.WypiszInfo();
