using Movies.Api.Models;

namespace Movies.Api
{
    public class MovieRepository
    {
        public List<Movie> Movies = new()
        {
            new Movie
            {
                Name="Gold Rush",
                YearReleased=2020,
                Genre="Thriller",
                Id=1
            }
        };
    }
}
