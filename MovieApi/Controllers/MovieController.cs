using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApi.Entities;
using MovieApi.Services;
namespace MovieApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly MovieService s;
        public MovieController()
        {
            this.service = new MovieService();
        }
        [HttpGet]
        [Route("GetByActor/{director}")]
        public IActionResult GetByDirector(string dir)
        {
            Movie Movie = s.GetByDirector(dir);
            return StatusCode(200, Movie);
        }
        [Route("GetAllMovies")]
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Movie> Movies = s.GetAll();
            return StatusCode(200, Movies);
        }
        [HttpGet]
        [Route("GetById/{id}")]
        public IActionResult GetById(int id)
        {
            Movie Movie = s.GetById(id);
            return StatusCode(200, Movie);
        }
        [HttpGet]
        [Route("GetByActor/{actor}")]
        public IActionResult GetByActor(string actor)
        {
            Movie Movie = s.GetByActor(actor);
            return StatusCode(200, Movie);
        }
        [HttpGet]
        [Route("GetByActor/{language}")]
        public IActionResult GetByLanguage(string lan)
        {
            Movie Movie = s.GetByLanguage(lan);
            return StatusCode(200, Movie);
        }
        
        [HttpPut]
        [Route("Edit")]
        public IActionResult Edit(Movie Movie)
        {
            s.Edit(Movie);
            return StatusCode(200, Movie);
        }

        [HttpPost]
        [Route("Add")]
        public IActionResult Add(Movie Movie)
        {
            s.Add(Movie);
            return StatusCode(200, Movie);
        }
        [HttpDelete]
        [Route("Delete/{id}")]
        public IActionResult Delete(int id)
        {
            s.Delete(id);
            return StatusCode(200,id);
        }
        
    }
}