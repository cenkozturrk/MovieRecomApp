using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecommendation.Core.Services
{
    public class MovieRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;
        public MovieRepository(DbContext context)
        {
            this._context = context ?? throw new ArgumentException(null, nameof(context));
            _dbSet = this._context.Set<TEntity>();
        }

        public void CreateMovie(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void CreateRange(IEnumerable<TEntity> entities)
        {
            _dbSet.AddRange(entities);
        }

        public void DeleteMovie(Guid id)
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

        public void UpdateMovie(TEntity entity)
        {
            _dbSet.Update(entity);
        }
    }
}
