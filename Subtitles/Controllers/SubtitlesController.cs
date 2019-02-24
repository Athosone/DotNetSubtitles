using System;
using System.Threading.Tasks;
using Application.Queries;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Subtitles.Controllers;

namespace Subtitles
{
    [ApiController]
    public class SubtitlesController
    {
        public IQueryHandler<GetEpisodeQuery, Episode> EpisodeQueryHandler { get; }
        public IQueryHandler<GetSubtitleQuery, Subtitle> SubtitleQueryHandler { get; }

        public SubtitlesController(IQueryHandler<GetEpisodeQuery, Episode> episodeQueryHandler, 
        IQueryHandler<GetSubtitleQuery, Subtitle> subtitleQueryHandler)
        {
            EpisodeQueryHandler = episodeQueryHandler;
            SubtitleQueryHandler = subtitleQueryHandler;
        }

        [HttpPost]
        [Route("v1/subtitles")]
        public async Task<Subtitle> FindSubtitle([FromBody] FindSubtitleDto value)
        {
            var episodeFormatter = new EpisodeFormatter(value.FileName);
            var query = new GetSubtitleQuery
            {
                EpisodePath = value.FilePath,
                ShowName = episodeFormatter.ShowName(),
                SeasonNumber = episodeFormatter.SeasonNumber(),
                EpisodeNumber = episodeFormatter.EpisodeNumber(),
                EpisodeName = episodeFormatter.EpisodeName()
            };
            var result = await SubtitleQueryHandler.Execute(query);
            return result;
        }
    }
}
