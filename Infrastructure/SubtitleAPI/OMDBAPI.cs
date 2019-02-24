using System;
using System.Net.Http;
using System.Threading.Tasks;
using Domain;
using Newtonsoft.Json;

namespace Infrastructure
{
    public class OMDBAPI
    {
        private static readonly string BaseAddress = "http://omdbapi.com/?apikey=e6fe729a";
        public OMDBAPI()
        {
        }

        public async Task<String> GetImdbId(string showName)
        {
            using (HttpClient client = new HttpClient())
            {
                var address = BaseAddress + "&s=" + showName + "&t=series";
                var uri = Uri.EscapeUriString(address);
                var result = await client.GetAsync(address);
                var stringResult = await result.Content.ReadAsStringAsync();

                var omdbResult = JsonConvert.DeserializeObject<OMDBResult>(stringResult);
                return omdbResult.Search?[0].ImdbId ?? "";
            }
        }

    }
}
