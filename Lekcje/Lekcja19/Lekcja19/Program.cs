

using Lekcja19;
using System.Reflection;

CardFactory cf = new CardFactory();

Type t = cf.GetType();
//Type t = typeof(CardFactory);

Documentation docs = new Documentation();
docs.CreateClassDocs(t);
docs.CreateClassDocs(typeof(GameData));


GameData data = new GameData
{
    Title = "GTA",
    Price = 100,
    SalePrice = -1
};

Validator validator = new Validator();
validator.Validate(data);

validator.Validate(new Measure { Temperature = 5 });

Console.WriteLine(data.Id);
MethodInfo method = data.GetType().GetMethod("IncreaseId", BindingFlags.NonPublic | BindingFlags.Instance);
method.Invoke(data, null);
Console.WriteLine(data.Id);

ConstructorInfo constructor =  data.GetType().GetConstructor(BindingFlags.NonPublic | BindingFlags.Instance, new Type[0]);
GameData data2 = constructor.Invoke(null) as GameData;
Console.WriteLine(data2.Id);
