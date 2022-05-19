using Entities;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieRecommApp.Business.MediatR.Queries;
using MovieRecommendation.Core;
using MovieRecommendation.Core.Services;
using System.Net;

namespace MovieRecomApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private IRepository<Movie> _repository;

        private readonly IMediator mediator;


        public MovieController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var query = new GetMovieByIQuery() { Id = id };

            return Ok(await mediator.Send(query));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllMovieQuery();

            return Ok(await mediator.Send(query));
        }


    }
}
