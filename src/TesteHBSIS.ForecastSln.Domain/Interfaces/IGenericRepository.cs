using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using TesteHBSIS.ForecastSln.Domain.Entities;

namespace TesteHBSIS.ForecastSln.Domain.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        void Add(T obj);
        void Update(T obj);
        void Remove(Guid id);
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        IEnumerable<T> Get(Expression<Func<T, bool>> predicate);
    }
}
