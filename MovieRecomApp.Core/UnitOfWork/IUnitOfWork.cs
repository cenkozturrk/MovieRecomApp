using Entities;
using MovieRecommendation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecomApp.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Movie> GetRepository<Movie>() where Movie : class;

        int Complete();
    }
}
