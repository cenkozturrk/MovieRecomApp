using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecommendation.Core.Services
{
    public class MovieRepository<Movie> : IRepository<Movie> where Movie : class
    {
        private readonly DbContext _context;
        private readonly DbSet<Movie> _dbSet;
        private readonly IRepository<Movie> _repository;
        public MovieRepository(DbContext context)
        {
            this._context = context ?? throw new ArgumentException(null, nameof(context));
            _dbSet = this._context.Set<Movie>();
        }

        public void CreateMovie(Movie entity)
        {
            _dbSet.Add(entity);
        }

        public void CreateRange(IEnumerable<Movie> entities)
        {
            _dbSet.AddRange(entities);
        }

        public void DeleteMovie(Guid id)
        {
            _dbSet.Remove(GetById(id));
        }

        public void DeleteRange(IEnumerable<Movie> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public IEnumerable<Movie> GetAll()
        {
            return _dbSet.ToList();
        }

        public Movie GetById(Guid id)
        {
            return _dbSet.Find(id);
        }

        public void UpdateMovie(Movie entity)
        {
            _dbSet.Update(entity);
        }
    }
}
