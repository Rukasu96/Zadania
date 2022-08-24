using Bag;

Sword s = new Sword(20);
Shield sh = new Shield("Wooden shield", 15);
Backpack bp1 = new Backpack();

bp1.AddItem(s);
bp1.AddItem(sh);

Backpack bp2 = new Backpack();
bp2.AddItem(bp1);

bp2.AddItem(new Shield("Gold Shield", 40));
Console.WriteLine(bp2.ItemWeight());

Item item = new Shield("Silver", 10);
//Item item2 = new Item();
