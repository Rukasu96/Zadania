using lekcja6;

Dictionary<string, double> oceny = new Dictionary<string, double>();
oceny.Add("Ola Kowalska", 5);
oceny.Add("Magda Nowak", 4.5);
oceny.Add("Jan Kowalczyk", 3);
oceny["Ada Nowacka"] = 2;

foreach(var item in oceny)
{
    //Console.WriteLine(item);
    Console.WriteLine(item.Key + " " + item.Value);
}

HttpClient client = new HttpClient();
var response = await client.GetAsync("https://en.wikipedia.org/wiki/Ayman_al-Zawahiri").Result.Content.ReadAsStringAsync();
var words = response.Split(" ").Where(x => x.Length < 20).ToList();

Dictionary<string, int> count = new Dictionary<string, int>();
foreach (var w in words)
{
    if(count.ContainsKey(w))
    {
        count[w]++;
    }
    else
    {
        count[w] = 1;
    }
}

//Console.WriteLine();
//foreach (var item in count.Where(x => !x.Key.Contains("<") && !x.Key.Contains(">")).OrderByDescending(x => x.Value))
//{
//    Console.WriteLine(item);
//}

Car c1 = new Car("Daewoo", "Matiz");
Car c2 = new Car("Daewoo", "Lanos");
Car c3 = new Car("Daewoo", "Espera");

Dictionary<Car, int> cars = new Dictionary<Car, int>();
cars.Add(c1, 3);
cars.Add(c2, 10);
cars.Add(c3, 1);

Console.WriteLine(cars[c1]);

Car c4 = new Car("Daewoo", "Matiz");
Console.WriteLine(cars[c4]);

Console.WriteLine(c1.Equals(c4));
Console.WriteLine(c1.GetHashCode());
Console.WriteLine(c4.GetHashCode());

HashSet<Car> carsSet = new HashSet<Car>();
carsSet.Add(c1);
carsSet.Add(c2);
carsSet.Add(c3);
carsSet.Add(c4);
Console.WriteLine("Count: " + carsSet.Count);