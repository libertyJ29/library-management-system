using Microsoft.AspNetCore.Mvc;

namespace Library2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "About Lakeview ILS Library";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact your local Library Branch";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
