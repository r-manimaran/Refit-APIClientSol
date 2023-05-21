using Movies.Api.Models;

namespace Movies.Api
{
    public interface IMovieService
    {
        Task CreateMovieAsync(Movie movie);
        Task<Movie> GetMovieByIdAsync(int id);
        Task UpdateMovieAsync(int id, Movie movie);
        Task DeleteMovieByIdAsync(int id);
    }
}
