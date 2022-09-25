using lekcja6;

Parking p = new Parking();
p.AddCar(new Car("Daewoo", "Matiz"));
p.AddCar(new Car("Daewoo", "Lanos"));
p.AddCar(new Car("Daewoo", "Espera"));
foreach (var item in p)
{
    Console.WriteLine(item);
}

Stos s = new Stos();
s.Add(10);
s.Add(20);
s.Add(30);

foreach(var number in s)
{
    Console.WriteLine(number);
}

var e = s.GetEnumerator();

while(e.MoveNext())
{
    Console.WriteLine(e.Current);
}

IEnumerable<int> Kostka(int count)
{
    Random random = new Random();
    for(int i = 0; i < count; i++)
    {
        yield return random.Next(1, 7);
    }
}

Console.WriteLine();
foreach(var num in Kostka(10))
{
    Console.WriteLine(num);
}

Kostka(10).OrderBy(x => x).ToList().ForEach(x => Console.Write(x + " "));
Console.WriteLine();