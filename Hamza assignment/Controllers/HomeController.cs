using Microsoft.AspNetCore.Mvc;

namespace Hamza_assignment.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult contact()
        {
            return View();
        }
    }
}
