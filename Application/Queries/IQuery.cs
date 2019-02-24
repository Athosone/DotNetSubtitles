using System;
using System.Threading.Tasks;

namespace Application.Queries
{
    public interface IQuery
    {
    }

    public interface IQueryHandler<TQuery, TResult> where TQuery : IQuery
    {
        Task<TResult> Execute(TQuery query);
    }

    public interface IQueryDispatcher
    {
        TResult Execute<TResult, TQuery>(TQuery query) where TQuery : IQuery;
    }
}
