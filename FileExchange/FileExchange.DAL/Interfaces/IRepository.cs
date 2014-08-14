using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

using FileExchange.Domain.Abstract;


namespace FileExchange.DAL.Interfaces
{
    public interface IRepository<TEntity> where TEntity : IIntBaseEntity
    {
        TEntity GetById(int id);

        IQueryable<TEntity> GetAll();

        IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] includeProperties);

        void Add(TEntity entity);

        void Update(TEntity entity);

        void Delete(TEntity entity);

        void Delete(int id);
    }
}