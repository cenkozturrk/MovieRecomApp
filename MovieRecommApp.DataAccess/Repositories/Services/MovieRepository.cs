using Entities;
using Microsoft.EntityFrameworkCore;
using MovieRecomApp.Core.Repositories.Abstract;
using MovieRecommendation.Core;
using MovieRecommendation.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecommApp.DataAccess.Repositories
{
    public class MovieRepository : EntityRepository<Movie, EntityContext>, IMovieRepository
    {
        public MovieRepository(DbContext context, DbSet<Movie> dbSet, IRepository<IEntity> repository) : base(context, dbSet, repository)
        {
        }
    }
}
