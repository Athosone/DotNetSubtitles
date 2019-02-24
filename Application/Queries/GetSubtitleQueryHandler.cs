using System;
using System.Threading.Tasks;
using Domain;

namespace Application.Queries
{
    public class GetSubtitleQueryHandler: IQueryHandler<GetSubtitleQuery, Subtitle>
    {
        private readonly ISubtitleAPI subtitleAPI;

        public GetSubtitleQueryHandler(ISubtitleAPI subtitleAPI) => this.subtitleAPI = subtitleAPI;

        public async Task<Subtitle> Execute(GetSubtitleQuery query)
        {
            var result = await subtitleAPI.GetSubtitleAsync(query);

            return result;

        }
    }
}
