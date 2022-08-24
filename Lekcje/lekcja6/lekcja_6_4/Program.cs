using System.Diagnostics;

void Create()
{
    Random rand = new Random();
    using(StreamWriter sw = new StreamWriter("dane.txt"))
    {
        for(int i = 0; i < 1000000000; i++)
        {
            char literka = (char)rand.Next('a', 'z' + 1);
            sw.Write(literka);
        }
    }
}

//Create();

int Ilosc(string text, int from, int to)
{
    int count = 0;
    for(int i = from; i < to; i++)
    {
        if (text[i] == 'a')
        {
            count++;
        }
    }
    return count;
}

string text = File.ReadAllText("dane.txt");

List<Task<int>> tasks = new List<Task<int>>();

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

int n = 12;
int step = text.Length / n;
for(int i = 0; i < n; i++)
{
    int from = i * step;
    int to = (i + 1) * step;
    tasks.Add(Task.Run(() => Ilosc(text, from, to)));
}

//Func<int> funkcja = () => Ilosc(text, 0, text.Length);
//funkcja();

int liczba = 0;
foreach(var task in tasks)
{
    liczba += await task;
}
Console.WriteLine(liczba);

stopwatch.Stop();
Console.WriteLine(stopwatch.ElapsedMilliseconds);