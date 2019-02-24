using System;
using System.Threading.Tasks;
using Application.Queries;
using Domain;

namespace Application
{
    public interface ISubtitleAPI
    {
        Task<Subtitle> GetSubtitleAsync(GetSubtitleQuery subtitleQuery);
    }
}
