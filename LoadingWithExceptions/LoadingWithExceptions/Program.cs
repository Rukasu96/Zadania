int suma = 0;
int iloscLiczb = 0;
float srednia = 0F;

Console.WriteLine("Podaj liczby aby policzyć średnią");

do
{
    Console.Write("Twoja Liczba: ");
    try
    {
        int ocena = int.Parse(Console.ReadLine());
        suma += ocena;
        iloscLiczb++;
        srednia = suma / iloscLiczb;
    }
    catch(FormatException ex)
    {
        Console.WriteLine($"Twoja srednia: {srednia}");
        break;
    }
    
} while (true);



