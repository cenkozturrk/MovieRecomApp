using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecommendation.Core
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetById(Guid id);
        IEnumerable<TEntity> GetAll();
        void CreateMovie(TEntity entity);
        void CreateRange(IEnumerable<TEntity> entities);
        void UpdateMovie(TEntity entity);
        void DeleteMovie(Guid id);
        void DeleteRange(IEnumerable<TEntity> entities);

    }
}
