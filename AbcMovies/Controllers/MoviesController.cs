using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AbcMovies.Models;

namespace AbcMovies.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movie = new Movie(){Name= "Shrek!"};
            return View(movie);
        }
    }
}