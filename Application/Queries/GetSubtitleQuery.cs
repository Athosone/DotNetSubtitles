using System;
namespace Application.Queries
{
    public class GetSubtitleQuery: IQuery
    {
        public String ShowName { get; set; }
        public String EpisodeName { get; set; }
        public String SeasonNumber { get; set; }
        public String EpisodeNumber { get; set; }
        public Uri EpisodePath { get; set; }

        public GetSubtitleQuery()
        {
        }
    }
}
