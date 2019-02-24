using System;
namespace Subtitles.Controllers
{
    public class EpisodeFormatter
    {
        private readonly string[] nameParts;
        public EpisodeFormatter(string fileName)
        {
            this.nameParts = fileName.Split("-");
        }

        public string ShowName()
        {
            return nameParts[0].Trim();
        }

        public string EpisodeName()
        {
            return nameParts[2].Replace("WEBDL", "").Trim();
        }

        public string SeasonNumber()
        {
            var season = nameParts[1].Trim();
            var episodeTagIndex = season.IndexOf("E");
            var lRet = season.Remove(episodeTagIndex);
            lRet = lRet.Replace("S", "");
            lRet = lRet.Replace("0", "");

            return lRet;
        }

        public string EpisodeNumber()
        {
            var season = nameParts[1].Trim();
            var seasonTagIndex = season.IndexOf("S");
            var lRet = season.Remove(seasonTagIndex, 4);
            if (lRet.StartsWith("0"))
            {
                lRet = lRet.Remove(0, 1);
            }
            return lRet.Trim();
        }
    }
}
