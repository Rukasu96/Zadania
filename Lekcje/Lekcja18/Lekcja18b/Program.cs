using Lekcja18b;

ICoffee coffee = new BasicCoffee();
coffee = new MilkDecorator(coffee);
coffee = new MilkDecorator(coffee);
coffee = new SugarDecorator(coffee);

Console.WriteLine(coffee.GetDescription());
Console.WriteLine(coffee.GetCost());
