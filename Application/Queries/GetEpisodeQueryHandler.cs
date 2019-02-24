using System;
using System.Threading.Tasks;
using Domain;

namespace Application.Queries
{
    public class GetEpisodeQueryHandler: IQueryHandler<GetEpisodeQuery, Episode>
    {
        private readonly IRepository<Episode> respository;

        public GetEpisodeQueryHandler(IRepository<Episode> repository)
        {
            this.respository = repository;
        }

        public async Task<Episode> Execute(GetEpisodeQuery query)
        {
            throw new NotImplementedException();
        }
    }
}
