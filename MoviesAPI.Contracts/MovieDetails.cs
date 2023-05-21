using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesAPI.Contracts;

public record MovieDetails(string Name, string Genre, int YearReleased);

