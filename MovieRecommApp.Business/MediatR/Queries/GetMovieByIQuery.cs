using Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRecommApp.Business.MediatR.Queries
{
    public class GetMovieByIQuery :IRequest<GetMovieViewModel>
    {
        public Guid Id { get; set; }
    }
}
