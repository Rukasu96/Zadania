using Drukarki;

List<IDrukowanie> drukujace = new List<IDrukowanie>();
List<ISkanowanie> skanujace = new List<ISkanowanie>();

Drukarka drukarka = new Drukarka("LG", "1000", 0);
Skaner skaner = new Skaner("Logitech", "025", 5);
UrządzenieWielofunkcyjne urzadzenieWielofunkcyjne = new UrządzenieWielofunkcyjne("Philips", "0332", 2,"USB");

drukujace.Add(drukarka);
drukujace.Add(urzadzenieWielofunkcyjne);
skanujace.Add(skaner);
skanujace.Add(urzadzenieWielofunkcyjne);

foreach (IDrukowanie item in drukujace)
{
    Console.WriteLine(item.Drukuj());
}

foreach (ISkanowanie item in skanujace)
{
    Console.WriteLine(item.Skanuj());
}
