using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieStore.Models;

namespace MovieStore.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            var Movie = new Movie() { Name="Ajeet Kumar"};
            return Content("Hello");
        }

        public ActionResult Edit(int? actionResult, string sortBy)
        {
            if (!actionResult.HasValue == true)
                actionResult = 1;
            if (string.IsNullOrEmpty(sortBy))
                sortBy = "Name";
            return Content(string.Format("ActionResult={0}& SortBy={1}", actionResult, sortBy));
        }
        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year+"/"+ month);
        }
    }
}