using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        public MovieController(IRepository<Movie> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public Movie Get(Guid id)
        {
            return _repository.GetById(id);
        }

        [HttpGet("{id}")]
        public List<Movie> Get()
        {
            return (List<Movie>)_repository.GetAll();
        }


        [HttpPost]
        public void Post([FromBody]Movie movie)
        {
            _repository.CreateMovie(movie);
        }

        [HttpPost]
        public void PostRange([FromBody]Movie movie)
        {
             _repository.CreateRange(movie);
        }

        [HttpPut]
        public void Put([FromBody] Movie movie)
        {
             _repository.UpdateMovie(movie);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
             _repository.DeleteMovie(id);
        }

        [HttpDelete()]
        public void DeleteRange(Guid id)
        {
            _repository.DeleteMovie(id);
        }
    }
}
