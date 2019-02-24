using System;
using System.Threading.Tasks;
using Application;
using Application.Queries;
using Domain;

namespace Infrastructure
{
    public class SubtitleAPI: ISubtitleAPI
    {
        private readonly OpenSubtitlesAPI openSubtitlesAPI;
        private readonly OMDBAPI omdbAPI;

        public SubtitleAPI()
        {
            this.openSubtitlesAPI = new OpenSubtitlesAPI();
            this.omdbAPI = new OMDBAPI();
        }

        public async Task<Subtitle> GetSubtitleAsync(GetSubtitleQuery subtitleQuery)
        {
            // First we search for the imdbid of the show on OMDBAPI
            var imdbID = await omdbAPI.GetImdbId(subtitleQuery.ShowName);

            var result = await openSubtitlesAPI.getSubtitle(subtitleQuery.EpisodeNumber, imdbID, subtitleQuery.SeasonNumber);

            var subtitle = new Subtitle
            {
                EpisodeName = subtitleQuery.EpisodeName,
                FileURL = result,
                Language = "EN"
            };
            return subtitle;
        }
    }
}
