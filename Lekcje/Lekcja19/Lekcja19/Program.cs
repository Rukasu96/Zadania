

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
    SalePrice = 40
};

PropertyInfo[] properties = data.GetType().GetProperties();
foreach (PropertyInfo property in properties)
{
    //Attribute attrs = property.GetCustomAttribute(); // dokonczyc
}