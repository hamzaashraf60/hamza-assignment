using Hamza_assignment.Data;
using Hamza_assignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hamza_assignment.Controllers
{
    public class homeController : Controller
    {

        private readonly DataContext _context;
        private DataContext _write;
        public IActionResult Index()
        {
            return View();
        }

        public homeController(DataContext context)
        {
            _context = context;
            _write = context;
        }

        public IActionResult contact()
        {
            return View(_context.messa.ToList());
        }

        public IActionResult form(customerMessage s)
        {
            _write.messa.Add(s);
            _write.SaveChanges();
            return View("Index");
        }
    }
}
