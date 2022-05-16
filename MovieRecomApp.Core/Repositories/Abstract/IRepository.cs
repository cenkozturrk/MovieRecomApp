using MovieRecomApp.Core.Repositories.Abstract;
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
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);
        void Delete(Guid id);
        void DeleteRange(IEnumerable<TEntity> entities);

    }
}
