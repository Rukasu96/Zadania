class Program
{
    delegate char delegat(char c);

    static string Podmien(string tekst, delegat operacja)
    {
        string podmienionyNapis = "";

        List<char> c = new List<char>();
        foreach (char letter in tekst)
        {
            podmienionyNapis += operacja(letter);
        }
        return podmienionyNapis;
    }


    public static void Main(string[] args)
    {
        string napis = "Ala ma kota";
        string weronika = "Weronika";
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

        Console.WriteLine(Podmien(napis, x => x == 'a' ? 'o' : x));
        Console.WriteLine(Podmien(weronika, x => vowels.Contains(x) ? '_' : x));
    }
}