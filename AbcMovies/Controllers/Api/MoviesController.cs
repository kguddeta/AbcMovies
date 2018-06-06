using AbcMovies.Dtos;
using AbcMovies.Models;
using AutoMapper;
using System;
using System.Linq;
using System.Web.Http;

namespace AbcMovies.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/Movies
        public IHttpActionResult GetMovies()
        {
            var movieDtos = _context.Movies.ToList().Select(Mapper.Map<Movie,MovieDto>);
            return Ok(movieDtos);
        }

        // GET api/movies/1
        public IHttpActionResult GetMovie(int id)
        {
            var movieDto = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movieDto == null)
                return NotFound();
            return Ok(Mapper.Map<Movie, MovieDto>(movieDto));
        }

        // POST /api/movies
        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto movieDto)
        {
            if (movieDto == null)
                return BadRequest();
            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            _context.Movies.Add(movie);
            _context.SaveChanges();
            movieDto.Id = movie.Id;
            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto);
        }

        // Update /api/customer/1
        [HttpPut]
        public IHttpActionResult UpdateMovie(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movieInDb == null)
                return BadRequest();
            Mapper.Map(movieInDb, movieInDb);
            _context.SaveChanges();
            return Ok();
        }

        // DELETE /api/movie/1
        [HttpDelete]
        public IHttpActionResult DeleteMovie(int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movieInDb == null)
                return NotFound();
            _context.Movies.Remove(movieInDb);
            _context.SaveChanges();
            return Ok();
        }
    }
}
