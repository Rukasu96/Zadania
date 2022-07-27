using Franki;

KursFranka kurs = new KursFranka(2.7f);

Osoba os1 = new Osoba("Jan", "Kowalski", 30000);
Osoba os2 = new Osoba("Zdzisław", "Janowski", 23000);

kurs.DodajZainteresowanego(os1);
kurs.DodajZainteresowanego(os2);

kurs.Przelicznik = 2.8f;