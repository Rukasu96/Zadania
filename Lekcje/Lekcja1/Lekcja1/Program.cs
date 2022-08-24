using System;

namespace Lekcja1
{
    class Program
    {
        static void Main(string[] args)
        {
            Paczka p = new Paczka(-5, 10, "Ada Kowalska");
            //.........
            p.SetWaga(15);
            p.Waga = -5;
            Console.WriteLine(p.Waga);
            //p.waga = -50;
            //p.wysokosc = 5;
            //p.adresat = "Ada Kowalska";
            Console.WriteLine(p);

            Kontener k = new Kontener("Jan Nowak");
            PrzesylkaKurierska pk = new PrzesylkaKurierska(7, 10, "Tomasz Kowalczyk", new DateTime(2022, 6, 28));

            Console.WriteLine(p.Cena());
            Console.WriteLine(k.Cena());
            Console.WriteLine(pk.Cena());

            Uzytkownik u = new Uzytkownik();
            u.DodajPaczke(p);
            u.DodajPaczke(k);
            u.DodajPaczke(pk);
            Console.WriteLine(u);


            k = null;
        }
    }
}
