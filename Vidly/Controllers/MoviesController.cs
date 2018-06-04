using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ViewResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        }

        [Route("movies/release/{year:regex(^\\d{4}$):range(1930, 2020)}/{month:regex(^\\d{2}$):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            string mon = month < 10 ? $"0{month.ToString()}" : month.ToString();
            return Content($"{year.ToString()}/{mon}");
        }
    }
}