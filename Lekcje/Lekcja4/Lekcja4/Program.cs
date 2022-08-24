//ObserverPattern
//delegaty
//wyrazenia lamba
//delegaty wbudowane
//eventy


using Lekcja4;

Player p = new Player();
//p.AddSubscriber(new HpStrip());
//p.AddSubscriber(new GameOver());

p.OnHpChange += (hp) => Console.WriteLine($"Hp: {hp}/100");
p.OnHpChange += (hp) =>
{
    if (hp == 0)
    {
        Console.WriteLine("Game over");
        Environment.Exit(0);
    }
};

Random rand = new Random(); 
for(int i = 0; i < 20; i++)
{
    int attack = rand.Next(1, 10);
    p.Hit(attack);
}

Console.WriteLine("You win!");

