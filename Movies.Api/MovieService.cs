using Movies.Api.Models;

namespace Movies.Api
{
    public class MovieService : IMovieService
    {
        private readonly MovieRepository _movieRepository;

        public MovieService(MovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }
        public Task CreateMovieAsync(Movie movie)
        {
            throw new NotImplementedException();
        }

        public Task DeleteMovieByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Movie> GetMovieByIdAsync(int id)
        {
            throw new NotImplementedException();
            //var movie = _movieRepository.Movies.FirstOrDefault(m => m.Id == id);
            //return movie;
        }

        public Task UpdateMovieAsync(int id, Movie movie)
        {
            throw new NotImplementedException();
        }
    }
}
