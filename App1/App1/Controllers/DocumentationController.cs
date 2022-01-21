using Microsoft.AspNetCore.Mvc;

namespace App1.Controllers
{
    public class DocumentationController : Controller
    {
        // GET
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AccessibilityStatement()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult ChangeLog()
        {
            return View();
        }
    }
}