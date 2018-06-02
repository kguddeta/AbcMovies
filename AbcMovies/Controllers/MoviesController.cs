using AbcMovies.Models;
using System.Web.Mvc;

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