using Lekcja9;

int a = 5;
int b = 6;

Console.WriteLine(a.CompareTo(b));
Console.WriteLine(b.CompareTo(a));
Console.WriteLine(a.CompareTo(a));

Baza<int> baza = new Baza<int>();
baza.Add(10);
baza.Add(2);
baza.Add(500);
baza.Add(1);
baza.Add(18);
baza.Sort();
Console.WriteLine(baza);

Baza<User> users = new Baza<User>();
users.Add(new User("Ada", "ada@gmail.com"));
users.Add(new User("Zuza", "zuza@gmail.com"));
users.Add(new User("Ada", "weresa@gmail.com"));
users.Add(new User("Ola", "ola@gmail.com"));
users.Add(new User("Adam", "adam@gmail.com"));
users.Sort2(new User.ByNameLength());
Console.WriteLine(users);


var text = "ada ma kota";
Console.WriteLine(StringExtension.RemoveCharacters(text, "a", " "));
Console.WriteLine(text.RemoveCharacters("a", " "));


List<int> ints = new List<int>();
ints.Add(10);
ints.Add(20);
ints.Add(30);
Console.WriteLine(ints);
Console.WriteLine(ints.GetString());

Console.WriteLine(users.GetString());