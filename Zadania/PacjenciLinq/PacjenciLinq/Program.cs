using PacjenciLinq;

Pacjent p1 = new Pacjent("Łukasz", "Kulesza", 96040107391, "EP34502", 26);
Pacjent p2 = new Pacjent("Jan", "Kowalski", 99021208696, "EP32254", 35);
Pacjent p3 = new Pacjent("Marcelina", "Chomicz", 88113112376, null, 40);
Pacjent p4 = new Pacjent("Aleksandra", "Szczygło", 75021492391, null, 60);
Pacjent p5 = new Pacjent("Kamil", "Grek", 85022909427, "EP24642", 52);

BazaPacjentow bazaPacjentów = new BazaPacjentow();

bazaPacjentów.DodajPacjenta(p1);
bazaPacjentów.DodajPacjenta(p2);
bazaPacjentów.DodajPacjenta(p3);
bazaPacjentów.DodajPacjenta(p4);
bazaPacjentów.DodajPacjenta(p5);

bazaPacjentów.StarsiNiż(36).ForEach(x => Console.WriteLine($"{x.Imie} {x.Nazwisko}"));
Console.WriteLine();

Pacjent znaleziony = bazaPacjentów.Znajdz("Marcelina", "Chomicz");
Console.WriteLine(znaleziony.Imie + " " + znaleziony.Nazwisko);

Console.WriteLine(bazaPacjentów.PoliczNieUbezpieczonych());

Console.WriteLine();
Console.WriteLine(bazaPacjentów);