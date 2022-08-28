
using PunktyLinq;

Punkt[] punkty = new Punkt[100];

for (int i = 0; i < punkty.Length; i++)
{
    Punkt punkt = new Punkt();
    punkty[i] = punkt;
}

//Ile punktów znajduje się w każdej ćwiartce
var firstPart = punkty.Count(x => x.PosX < 0 && x.PosY > 0);
var secondPart = punkty.Count(x => x.PosX > 0 && x.PosY > 0);
var thirdPart = punkty.Count(x => x.PosX < 0 && x.PosY < 0);
var fourthPart = punkty.Count(x => x.PosX > 0 && x.PosY < 0);

Console.WriteLine($"{firstPart}, {secondPart}, {thirdPart}, {fourthPart}");

//Które punkty mają wartość dwucyfrową x i y;
var doubleDigitPoints = punkty.Where(x => x.PosX.ToString().Length == 2 && x.PosY.ToString().Length == 2).ToList();
doubleDigitPoints.ForEach(x => Console.WriteLine(x.PosX + " " + x.PosY));

//Czy istnieje jakiś punkt o współrzędnej x == -20 && posY < 0
var anyPoint = punkty.Any(x => x.PosX == -20 && x.PosY < 0);
Console.WriteLine(anyPoint);

//Zamień punkty na listę stringów "(x,y)"
var stringPoints = punkty.Select(x => $"({x.PosX},{x.PosY})").ToList();
stringPoints.ForEach(x => Console.WriteLine(x));
