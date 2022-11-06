
//int opcja = -1;
//while(opcja != 4)
//{
//    Console.WriteLine("Podaj numer opcji");
//    Console.WriteLine("1. Zapis 2. Odczyt 3. Losowanie liczby 4. Wyjsice");
//    opcja = int.Parse(Console.ReadLine());
//    switch(opcja)
//    {
//        case 1:
//            Console.WriteLine("Zapis");
//            break;
//        case 2:
//            Console.WriteLine("Odczyt");
//            break;
//        case 3:
//            Console.WriteLine(new Random().Next(1, 7));
//            break;
//        case 4:
//            Console.WriteLine("Wyjscie");
//            break;
//    }
//}

using Lekcja13;

Menu menu2 = new Menu("Zapis");
menu2.Add(new MenuItem("Tekstowy", () => Console.WriteLine("Zapis tekstowy")));
menu2.Add(new MenuItem("Binarny", () => Console.WriteLine("Zapis binarny")));

Menu menu = new Menu("Menu główne");
menu.Add(menu2);
menu.Add(new MenuItem("Odczyt", () => Console.WriteLine("Odczyt")));
menu.Add(new MenuItem("Losowanie", () => Console.WriteLine(new Random().Next(1, 7))));
menu.Add(new DbReadUserMenuItem());
menu.Run();

