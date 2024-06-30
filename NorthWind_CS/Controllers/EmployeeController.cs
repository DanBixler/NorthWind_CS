using Microsoft.AspNetCore.Mvc;
using NorthWind_CS.Models;
using System.Linq;

namespace NorthWind_CS.Controllers
{
    public class EmployeeController : Controller
    {        
        public IActionResult Employees()
        {
            return View();
        }
    }
}
