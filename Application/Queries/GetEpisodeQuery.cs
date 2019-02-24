using System;
namespace Application.Queries
{
    public class GetEpisodeQuery: IQuery
    {
        public String ShowName { get; set; }
        public String EpisodeName { get; set; }
        public String SeasonNumber { get; set; }
        public String EpisodeNumber { get; set; }
    }
}
