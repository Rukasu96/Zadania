
using Lekcja10;

Pudelko p = new Pudelko(15, 20, 30, UnitOfMeasure.centimeter);
Console.WriteLine(p);
Console.WriteLine($"{p:mm}");

Pudelko p2 = new Pudelko();
Console.WriteLine(p2);

Pudelko p3 = p + p2;
Console.WriteLine(p3);

Pudelko p4 = new Pudelko();
if(p4 == p2)
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
    if(p1.V != p2.V)
    {
        return p2.V.CompareTo(p1.V);
    }else if(p1.V == p2.V)
    {
        return p2.area.CompareTo(p1.area);
    }else if(p1.V == p2.V && p1.area == p2.area)
    {
        double sum1 = p1.A + p1.B + p1.C;
        double sum2 = p2.A + p2.B + p2.C;
        return sum2.CompareTo(sum1);
    }
    return 0;
}
pudelka.Sort(volumeComparer);
Console.WriteLine();
pudelka.ForEach(x => Console.WriteLine(x));


