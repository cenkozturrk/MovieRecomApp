using Entities;
using MovieRecommendation.Core;
using MovieRecommendation.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MovieRecomApp.Core.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MovieContext _movieContext;
        public UnitOfWork(MovieContext context)
        {

            _movieContext = context;

            //MovieRepository<Movie> = new MovieRepository<Movie>(_movieContext);

            //Database.SetInitializer<MovieContext>(null);

            //if (_movieContext == null)
            //    throw new ArgumentNullException("dbContext can not be null.");

            // Buradan istenilen  EntityFramework'ü konfigure edebiliriz.

            //_movieContext.Configuration.LazyLoadingEnabled = false;
            //_movieContext.Configuration.ValidateOnSaveEnabled = false;
            //_movieContext.Configuration.ProxyCreationEnabled = false;
        }

        public IRepository<Movie> GetRepository<Movie>() where Movie : class
        {
            return new MovieRepository<Movie>(_movieContext);
        }
        public IRepository<Movie> Repository { get; private set; }

        public int Complete()
        {
           return _movieContext.SaveChanges();
        }

        public void Dispose()
        {
            _movieContext.Dispose();
        }
    }
}
