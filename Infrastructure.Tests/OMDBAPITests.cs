using System;
using System.Threading.Tasks;
using Domain;
using Xunit;

namespace Infrastructure.Tests
{
    public class OMDBAPITests
    {
        private const string ShowName = "origin";

        public OMDBAPITests()
        {
        }

        [Fact]
        public async Task GetImdbId()
        {
            var omdbRepo = new OMDBAPI();
            var result = await omdbRepo.GetImdbId(ShowName);

            Assert.NotEmpty(result);
        }
    }
}
