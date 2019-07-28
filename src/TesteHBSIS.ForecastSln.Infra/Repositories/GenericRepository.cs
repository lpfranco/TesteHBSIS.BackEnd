using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TesteHBSIS.ForecastSln.Domain.Entities;
using TesteHBSIS.ForecastSln.Domain.Interfaces;
using TesteHBSIS.ForecastSln.Infra.Contexts;

namespace TesteHBSIS.ForecastSln.Infra.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected readonly ForecastContext Context;
        protected readonly DbSet<T> Set;

        public GenericRepository(ForecastContext context)
        {
            Context = context;
            Set = Context.Set<T>();
        }

        public void Add(T obj)
        {
            obj.CreatedOn = DateTime.Now;
            Set.Add(obj);
        }

        public void Update(T obj)
        {
            obj.UpdatedOn = DateTime.Now;
            Set.Update(obj);
        }

        public void Remove(Guid id)
        {
            Set.Remove(GetById(id));
        }

        public IEnumerable<T> GetAll()
        {
            return Set.AsEnumerable();
        }

        public T GetById(Guid id)
        {
            return Set.Find(id);
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return Set.Where(predicate);
        }

        public int SaveChanges()
        {
            return Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
            GC.SuppressFinalize(this);
        }

    }
}
