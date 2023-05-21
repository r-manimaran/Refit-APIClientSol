using MoviesApi.Client.Endpoints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesApi.Client;

public class MovieApiClient
{  
    public MovieApiClient(Movies movies)
    {
        Movies = movies;
    }

    public Movies Movies { get; }
}
