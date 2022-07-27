class Program
{

    delegate char delegat(char c);

    static string Podmien(string tekst, delegat x)
    {
        return tekst;
    }


    public static void Main(string[] args)
    {
        string napis = "Ala ma kota";

        Console.WriteLine(Podmien(napis, x => x == 'a' ? 'o' : x));
    }
}