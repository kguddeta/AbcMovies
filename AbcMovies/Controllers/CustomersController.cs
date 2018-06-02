using AbcMovies.Models;
using System.Web.Mvc;

namespace AbcMovies.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customer = new Customer(){Name="John David"};
            return View(customer);
        }
    }
}