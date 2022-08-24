using System.Diagnostics;

async Task ZagotujWode()
{
    await Task.Delay(1000);
    Console.WriteLine("Woda zagotowana");
}

async Task ZrobKanapke()
{
    await Task.Delay(4000);
    Console.WriteLine("Kanapka zrobiona");
}

async Task<int> NakarmPsa()
{
    await Task.Delay(3000);
    Console.WriteLine("Pies nakarmiony");
    return 10;
}

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

Task t1 = ZagotujWode();
Task t2 = ZrobKanapke();
Task<int> t3 = NakarmPsa();

await t1;
await t2;
int liczba = await t3;

Console.WriteLine(liczba);

stopwatch.Stop();
Console.WriteLine(stopwatch.ElapsedMilliseconds);