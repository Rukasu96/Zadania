using Lekcja14;

Console.WriteLine();

//Pyłek
//Flyweight

//Pocisk (x, y), nazwa typu, atak, szybkosc

//normal 5 3
//fire 10 5
//ice 9 4

BulletType type = new BulletType
{
    Attack = 10,
    Speed = 3,
    Symbol = "#",
    Type = "fire"
};

BulletFactory bulletFactory = new BulletFactory(type);

while(true)
{
    Console.ReadLine();
    Bullet b = bulletFactory.Create();
    Task.Run(b.Move);
}