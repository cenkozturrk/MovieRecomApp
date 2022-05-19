using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecommApp.Business.MediatR.Queries
{
    public class GetAllMovieQueryHandler : IRequestHandler<GetAllMovieQuery, List<GetMovieViewModel>>
    {
        public Task<List<GetMovieViewModel>> Handle(GetAllMovieQuery request, CancellationToken cancellationToken)
        {
            var model = new GetMovieViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Movie"
            };

            var model2 = new GetMovieViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Movie2"
            };


            return Task.FromResult(new List<GetMovieViewModel>() { model, model2 });
        }
    }
}
