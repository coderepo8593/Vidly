using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.MockData
{
    public static class MockMovies
    {
        public static List<Movie> MovieData = new List<Movie>
        {
            new Movie {Id = 1, Name = "Shrek!"},
            new Movie {Id = 2, Name = "UP"},
        };
    }
}
