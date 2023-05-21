using MoviesAPI.Contracts;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesApi.Client.Interfaces;

public interface IMoviesClient
{
    [Post("/api/movies")]
    Task<MovieDetails> CreateMovieAsync([Body] MovieCreateUpdate newMovie);

    [Get("/api/movies/{id}")]
    Task<MovieDetails> GetMoviesByIdAsync(int id);

    [Get("/api/movies")]
    Task<List<MovieDetails>> GetMoviesAsync();

    [Put("/api/movies/{id}")]
    Task<MovieDetails> UpdateMovieAsync([Body] MovieCreateUpdate updatedMovie, int id);

    [Delete("/api/movies/{id}")]
    Task DeleteMovieAsync(int id);
}
