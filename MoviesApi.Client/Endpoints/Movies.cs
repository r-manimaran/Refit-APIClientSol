using MoviesApi.Client.Interfaces;
using MoviesAPI.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesApi.Client.Endpoints;

public class Movies
{
    private readonly IMoviesClient _moviesClient;

    public Movies(IMoviesClient moviesClient)
    {
        _moviesClient = moviesClient;
    }

    public async Task<MovieDetails> CreateMovieAsync(MovieCreateUpdate newMovie)
    {
        return await _moviesClient.CreateMovieAsync(newMovie);
    }

    public async Task<MovieDetails> GetMovieByIdAsync(int id)
    {
        return await _moviesClient.GetMoviesByIdAsync(id);
    }

    public async Task<List<MovieDetails>> GetMoviesAsync()
    {
        return await _moviesClient.GetMoviesAsync();
    }

    public async Task<MovieDetails> UpdateMovieAsync(MovieCreateUpdate updatedMovie, int id)
    {
        return await _moviesClient.UpdateMovieAsync(updatedMovie, id);
          
    }

    public async Task DeleteMovieAsync(int id)
    {
        await _moviesClient.DeleteMovieAsync(id);
    }
}
