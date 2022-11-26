using Lekcja14b;

Spawn spawn = new Spawn();
spawn.Add("black", new Blacknight("Janusz", 15));
spawn.Add("black2", new Blacknight("Smith", 20));
spawn.Add("red", new RedDevil(100));

Enemy en = spawn.Create("red");
Enemy en2 = spawn.Create("black2");
Enemy en3 = spawn.Create("black");
Enemy en4 = spawn.Create("black");
Blacknight en5 = (Blacknight)spawn.Create("black");
en5.SetAttack(80);
Enemy en6 = spawn.Create("red");

