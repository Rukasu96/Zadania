
using Lekcja10;

Pudelko p = new Pudelko(15, 20, 30, UnitOfMeasure.centimeter);
Console.WriteLine(p);
Console.WriteLine($"{p:mm}");

Pudelko p2 = new Pudelko();
Console.WriteLine(p2);

Pudelko p3 = p + p2;
Console.WriteLine(p3);

Pudelko p4 = new Pudelko();
if (p4 == p2)
{
    Console.WriteLine("Takie same?");
}

double[] values = (double[])p;
Console.WriteLine(String.Join(", ", values));


Pudelko p5 = (230, 178, 115);
Console.WriteLine(p5);

Console.WriteLine(p5[0]);

List<Pudelko> pudelka = new List<Pudelko>();

pudelka.Add(p);
pudelka.Add(p2);
pudelka.Add(p3);
pudelka.Add(p4);
pudelka.Add(p5);

pudelka.ForEach(x => Console.WriteLine(x));

Comparison<Pudelko> volumeComparer = new Comparison<Pudelko>(CompareBoxes);

static int CompareBoxes(Pudelko p1, Pudelko p2)
{
    if (p1.V != p2.V)
    {
        return p2.V.CompareTo(p1.V);
    }
    else if (p1.V == p2.V && p1.Area == p2.Area)
    {
        double sum1 = p1.A + p1.B + p1.C;
        double sum2 = p2.A + p2.B + p2.C;
        return sum2.CompareTo(sum1);
    }
    else
    {
        return p2.Area.CompareTo(p1.Area);
    }
}
pudelka.Sort(volumeComparer);
Console.WriteLine();
pudelka.ForEach(x => Console.WriteLine(x));


Pudelko p7 = p.Kompresuj();
Console.WriteLine(p7);


Console.WriteLine();
Losowe los = new Losowe(5, 11);
foreach(var x in los)
{
    Console.WriteLine(x);
}

Console.WriteLine();
los.Where(x => x > 7).ToList().ForEach(x => Console.WriteLine(x));


Pudelko p8 = new Pudelko(1, 2, 3);
Pudelko p9 = new Pudelko(1, 2, 3);
Console.WriteLine(p8 == p9);
Console.WriteLine(null == p9);
Console.WriteLine(p8 == null);

p8 = null;
p9 = null;
Console.WriteLine(p8 == p9);


Pudelko p10 = Pudelko.Parse("2.500 mm × 9.321 mm × 0.100 mm");
Console.WriteLine(p10);