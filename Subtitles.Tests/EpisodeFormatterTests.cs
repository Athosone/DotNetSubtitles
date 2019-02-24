using System;
using Subtitles.Controllers;
using Xunit;

namespace Subtitles.Tests
{
    public class EpisodeFormatterTests
    {
        private const string showName = "Big Little Lies";
        private const string episodeName = "Somebody's Dead";
        private const string seasonNumber = "1";
        private const string episodeNumber = "1";

        [Fact]
        public void FormatSuccess()
        {
            var ef = new EpisodeFormatter("Big Little Lies - S01E01 - Somebody's Dead WEBDL-1080p");
            Assert.Equal(ef.ShowName(), showName);
            Assert.Equal(ef.EpisodeName(), episodeName);
            Assert.Equal(ef.SeasonNumber(), seasonNumber);
            Assert.Equal(ef.EpisodeNumber(), episodeNumber);
        }
    }
}
