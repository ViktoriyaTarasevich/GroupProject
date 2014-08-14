using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

using FileExchange.DAL.Interfaces;
using FileExchange.Domain.Abstract;


namespace FileExchange.DAL.Concrete
{
    // TODO: Add not null validation
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, IIntBaseEntity
    {
        private readonly DbContext context;

        private readonly DbSet<TEntity> set;

        public Repository(DbContext ctx)
        {
            context = ctx;
            set = context.Set<TEntity>();
        }

        public TEntity GetById(int id)
        {
            return set.SingleOrDefault(t => t.Id == id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return set;
        }

        public IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> predicate,
            params Expression<Func<TEntity, object>>[] includeProperties)
        {
            var entities = IncludeProperties(includeProperties);

            return entities.Where(predicate).AsEnumerable();
        }

        public void Add(TEntity entity)
        {
            set.Add(entity);
        }

        public void Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            set.Remove(entity);
        }

        public void Delete(int id)
        {
            TEntity entity = GetById(id);
            if (entity != default(TEntity))
            {
                Delete(entity);
            }
        }

        private IQueryable<TEntity> IncludeProperties(params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> entities = set;
            foreach (var includeProperty in includeProperties)
            {
                entities = entities.Include(includeProperty);
            }
            return entities;
        }
    }
}