using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Domain;
using Newtonsoft.Json;

namespace Infrastructure
{
    public class OpenSubtitlesAPI
    {
        public OpenSubtitlesAPI()
        {
        }

        public async Task<Uri> getSubtitle(string episodeNumber, string imdbID, string season)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("User-Agent", "TemporaryUserAgent");
                var address = $"https://rest.opensubtitles.org/search/episode-{episodeNumber}/imdbid-{imdbID}/season-{season}/sublanguageid-en";
                var result = await client.GetAsync(address);

                var stringResult = await result.Content.ReadAsStringAsync();
                try {
                    var openSubtitlesResults = JsonConvert.DeserializeObject<List<OpenSubtitlesResults>>(stringResult);
                    return openSubtitlesResults.First().SubDownloadLink;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                return null;
            }
        }
    }
}