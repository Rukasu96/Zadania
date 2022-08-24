using Lekcja3;

//string[] oceny = new[] { "niedostateczny", "dostateczny", "dopuszczalny", "dobry", "bardzo dobry" };

//Console.WriteLine("Podaj ocene w formie liczby");
//try
//{
//    int ocena = int.Parse(Console.ReadLine());
//    Console.WriteLine("Twoja ocena to: " + oceny[ocena - 1]);
//    Console.WriteLine("Wszystko OK");
//}
//catch(IndexOutOfRangeException ex)
//{
//    Console.WriteLine("Podana ocena jest spoza zakresu 1-5");
//}
//catch(FormatException ex)
//{
//    Console.WriteLine(ex.Message);
//}
//catch(OverflowException)
//{
//    Console.WriteLine("Zbyt duza wartosc");
//}
//catch(Exception ex)
//{

//}

void C()
{
    Stos s = new Stos(1);
    s.Push(5);
    s.Push(1);
}

void B()
{
    C();
}

void A()
{
    B();
}

A();