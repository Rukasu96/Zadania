int suma = 0;
int iloscLiczb = 0;

Console.WriteLine("Podaj liczby aby policzyć średnią");

bool success = false;
do
{
    Console.Write("Twoja Liczba: ");
    try
    {
        int ocena = int.Parse(Console.ReadLine());
        suma += ocena;
        iloscLiczb++;
    }
    catch(FormatException ex)
    {
        float srednia = suma / iloscLiczb;
        Console.WriteLine($"Twoja srednia: {srednia}");
        success = true;
    }
    
} while (!success);



