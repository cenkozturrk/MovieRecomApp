using Entities;
using MediatR;
using MovieRecomApp.Core.Spec;
using MovieRecommApp.DataAccess;
using MovieRecommendation.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecommApp.Business.MediatR.Queries
{
    public class GetMovieByIdQueryHandler : IRequestHandler<GetMovieByIQuery, GetMovieViewModel>
    {

        private readonly IMediator _mediator;
        private readonly IRepository<Movie> _repository;

        public GetMovieByIdQueryHandler(
            IMediator mediator,
            IRepository<Movie> repository) =>
            (_mediator, _repository ) = ( mediator, repository );
        public Task<GetMovieViewModel> Handle(GetMovieByIQuery request, CancellationToken cancellationToken)
        {            

            var viewModel = new GetMovieViewModel()
            {
                Id = Guid.NewGuid(),
                Name = "Movie"
             
            };

            return Task.FromResult(viewModel); 

            //Get movie from repository
        }
    }
}
