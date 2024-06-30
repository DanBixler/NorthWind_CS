using Microsoft.AspNetCore.Mvc;
using NorthWind_CS.Models;
using System.Diagnostics;
using System.Linq;

namespace NorthWind_CS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly NorthwindContext _context;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _context = new NorthwindContext();
        }

        public IActionResult Index()
        {            
            return View();
        }

        public IActionResult Employees()
        {
            var employees = _context.Employees.ToList();
            return View(employees);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
