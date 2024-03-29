﻿
Dictionary<string, double> data = new Dictionary<string, double>();
data.Add("Warszawa", 17.67);
data.Add("Kraków", 19.32);
data.Add("Wrocław", 22.31);
data.Add("Katowice", 17.77);
data.Add("Rzeszów", 24.16);
data.Add("Poznań", 19.86);

//Wyższa niż 20
var moreThanTwenty = data.Where(x => x.Value > 20).ToList();
moreThanTwenty.ForEach(x => Console.WriteLine(x));

//Średnia temperatura
var average = data.Average(x => x.Value);
Console.WriteLine(average);

//Które miasta mają niższą temperaturę niż Poznań
var poznan = data["Poznań"];
var lessThanPoznan = data.Where(x => x.Value < poznan).ToList();
lessThanPoznan.ForEach(x => Console.WriteLine(x));

//Najwyższa temperatur
var maxTemp = data.Max(x => x.Value);
Console.WriteLine(maxTemp);

//W którym mieście jest najniższa temperatura
var minTemp = data.Min(x => x.Value);
var city = data.Where(x => x.Value == minTemp);

//Lista temperatur w porządku malejącym
var listOfTemp = data.OrderByDescending(x => x.Value).Select(x => x.Value).ToList();
listOfTemp.ForEach(x => Console.WriteLine(x));
