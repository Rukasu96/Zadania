using Lekcja16c;

Player p1 = new Player("Janusz");
Player p2 = p1.Clone() as Player;

p1.Move(5, 8);
p2.Move(10, 20);

p1.Name = "Ola";

Console.WriteLine(p1);
Console.WriteLine(p2);

PlayerFactory factory = new PlayerFactory();
factory.Add("knight", new Player("Janusz"));
factory.Add("knight2", new Player("Ada"));

Player npc = factory.GetNewPlayer("knight");