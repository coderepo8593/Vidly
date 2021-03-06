﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using Vidly.MockData;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ViewResult Index()
        {
            var viewModel = new MoviesViewModel
            {
                Movies = new List<Movie>()
            };

            return View(viewModel);
        }

        [Route("movies/detail/{id:regex(^\\d{1}$):range(1, 2)}")]
        public ViewResult Detail(int id)
        {
            var movies = MockMovies.MovieData[id - 1];

            return View(movies);
        }
    }
}