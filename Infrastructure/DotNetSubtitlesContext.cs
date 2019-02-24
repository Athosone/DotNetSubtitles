using System;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class DotNetSubtitlesContext: DbContext
    {
        private readonly IHostingEnvironment _env;

        public DotNetSubtitlesContext(IHostingEnvironment env)
        {
            _env = env;
        }
    }
}
