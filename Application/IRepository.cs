using System;
using System.Linq;
using Domain;

namespace Application
{
    public interface IRepository<TEntity> : IDisposable where TEntity : IEntity
    {
        void Add(TEntity obj);
        TEntity GetById(Guid id);
        IQueryable<TEntity> GetBy(Func<Boolean> isIn);
        void Update(TEntity obj);
        void Remove(Guid id);
    }
}
