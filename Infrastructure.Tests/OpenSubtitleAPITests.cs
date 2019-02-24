using System;
using System.Threading.Tasks;
using Domain;
using Xunit;

namespace Infrastructure.Tests
{
    public class OpenSubtitleAPITests
    {
        public OpenSubtitleAPITests()
        {
        }

        [Fact]
        public async Task GetSubtitleURI()
        {
            var openSubtitlesAPI= new OpenSubtitlesAPI();
            var result = await openSubtitlesAPI.getSubtitle("20", "4145054", "2");

            Assert.NotEmpty(result.AbsolutePath);
        }
    }
}
