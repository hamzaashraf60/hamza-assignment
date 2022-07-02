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
            ViewBag.message = "READY";
            return View();
        }

        public IActionResult form(string fname, string lname, string email, double phone, string gender, string dep)
        {
            if (fname != "" && lname != "" && email != "" && phone != null && gender != "" && dep != "")
            {
                ViewBag.message = "RECEIVED";
            }
            else
            {
                ViewBag.message = "Failed";
            }
            return View("contact");
        }
    }
}
