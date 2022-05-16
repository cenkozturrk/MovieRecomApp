using Entities;
using Microsoft.EntityFrameworkCore;
using MovieRecomApp.Core.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecommendation.Core.Services
{
    public class EntityRepository<TEntity, EntityContext> : IRepository<TEntity> where TEntity : class
    {

        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;
        private DbContext context;
        private DbSet<Movie> dbSet;
        private IRepository<IEntity> repository;

        public EntityRepository(DbContext context, DbSet<TEntity> dbSet, IRepository<TEntity> repository)
        {
            this._context = context ?? throw new ArgumentException(null, nameof(context));
            _dbSet = this._context.Set<TEntity>();
        }

        public EntityRepository(DbContext context, DbSet<Movie> dbSet, IRepository<IEntity> repository)
        {
            this.context = context;
            this.dbSet = dbSet;
            this.repository = repository;
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _dbSet.AddRange(entities);
        }

        public void Delete(Guid id)
        {
             _dbSet.Remove(GetById(id));
        }

        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public TEntity GetById(Guid id)
        {
            return _dbSet.Find(id);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }


        

       
    }
}
