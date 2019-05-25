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
            return View(Movie);
        }
    }
}