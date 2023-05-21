using Microsoft.Extensions.DependencyInjection;
using MoviesApi.Client.Endpoints;
using MoviesApi.Client.Interfaces;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesApi.Client.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddMovieApiClient(this IServiceCollection services,
                                     Action<MovieApiOptions> options)
    {
        var opt = new MovieApiOptions();
        options(opt);

        services.AddRefitClient<IMoviesClient>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(opt.BaseUrl));
        services.AddTransient<Movies>();
        services.AddTransient<MovieApiClient>();

    }
}
