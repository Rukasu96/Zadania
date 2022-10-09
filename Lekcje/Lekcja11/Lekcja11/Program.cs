using System.Text.RegularExpressions;

//Console.WriteLine("Podaj adres emial");
//string email = Console.ReadLine();
//if(Regex.IsMatch(email, @"^[a-zA-Z\.0-9]+@[a-zA-Z\.0-9]+\.[a-z]{2,}$"))
//{
//    Console.WriteLine("Email poprawny!");
//}

async Task getData()
{
    HttpClient client = new HttpClient();
    var response = await client.GetAsync("https://pbpython.com/pandas-html-table.html");
    var data = await response.Content.ReadAsStringAsync();
    data = data.Replace("\n", "");
    var match = Regex.Match(data, "<tbody>.*</tbody>").Value;
    var rows = Regex.Matches(match, "<tr>(.*?)</tr>");
    foreach (Match r in rows)
    {
        var cols = Regex.Matches(r.Value, "<td>(.*?)</td>");
        cols.ToList().ForEach(x => Console.WriteLine(x.Groups[1]));
    }
}

await getData();