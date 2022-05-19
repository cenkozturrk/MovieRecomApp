using Ardalis.Specification;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecomApp.Core.Spec
{
    public class MovietByIdSpec : Specification<Movie>, ISingleResultSpecification
    {
        public MovietByIdSpec(Guid id) => Query
            .Where(p => p.Id == id)
            .Include(t => t.Point)
            .Include(t => t.Note)
            .OrderBy(c => c.Name);

            
            
    }
}