using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.Api.Models;
using MoviesAPI.Contracts;

namespace Movies.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MovieRepository _repo;

        public MoviesController(MovieRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        public IActionResult GetMovies()
        {
            var movies = _repo.Movies;
            return Ok(movies);
        }

        [HttpGet("{id}")]
        public IActionResult GetMovieById(int id)
        {
            var movie = _repo.Movies.FirstOrDefault(m=>m.Id == id);
            if (movie == null) return NotFound();
        
            return Ok(movie);
        }

        [HttpPost]
        public IActionResult CreateMovie(MovieCreateUpdate movie)
        {
            var randomId = new Random().Next(0, 100);
            var newMovie = new Movie
            {
                Name=movie.Name,
                Genre = movie.Genre,
                YearReleased = movie.YearReleased,
                Id= randomId
            };
            _repo.Movies.Add(newMovie);
            var movieDetails = new MovieDetails(newMovie.Name, newMovie.Genre, newMovie.YearReleased);

            return  CreatedAtAction(nameof(GetMovieById), new {id=randomId}, movieDetails);


            //_repo.Movies.ForEach(m =>
            //{
            //    movieDetails.Add(new MovieDetails(m.Name, m.Genre, m.YearReleased));
            //});

            return Ok(movieDetails);
           
        }
        [HttpPut]
        [Route("{id}")]
        public IActionResult UpdateMovie(int id, MovieCreateUpdate movie)
        {
            var movieToUpdate = _repo.Movies.FirstOrDefault(m => m.Id == id);
            if(movieToUpdate == null) return NotFound();

            movieToUpdate.Name = movie.Name;
            movieToUpdate.Genre = movie.Genre;
            movieToUpdate.YearReleased = movie.YearReleased;

            var movieDetails = new MovieDetails(movieToUpdate.Name, movieToUpdate.Genre, movieToUpdate.YearReleased);
            return Ok(movieDetails);
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteMovie(int id)
        {
            var movieToDelete = _repo.Movies.FirstOrDefault(m => m.Id == id);
            if (movieToDelete == null) return NotFound();

            _repo.Movies.Remove(movieToDelete);
            return NoContent();
        }
    }
}
