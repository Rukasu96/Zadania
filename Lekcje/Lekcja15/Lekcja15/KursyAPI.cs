using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja15
{
    public class KursyAPI : IDataSource
    {
        public async Task<Kurs[]> GetData()
        {
            HttpClient client = new HttpClient();
            var kursy = await client.GetFromJsonAsync<Kurs[]>("https://api.nbp.pl/api/cenyzlota/last/10?format=json");
            return kursy;
        }
    }
}
