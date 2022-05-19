using MediatR;
using MovieRecomApp.Core.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecommApp.Business.MediatR.Commands
{
    public class CreateMovieCommand: IRequest<Guid>
    {
        public string Name { get; set; }
        public int Point { get; set; }
        public string Note { get; set; }
    }

    public class CreateMovieCommandHandler : IRequestHandler<CreateMovieCommand, Guid>
    {
        public Task<Guid> Handle(CreateMovieCommand request, CancellationToken cancellationToken)
        {


            return Task.FromResult(Guid.NewGuid());
            //repository aracılığı ile veri veritabanına gönderildi.
        }
    }

    public class CreateMovieValidator : MovieValidator<CreateMovieCommand>
    {
        public CreateMovieValidator()
        {

        }
    }
}
