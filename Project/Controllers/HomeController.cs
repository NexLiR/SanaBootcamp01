using Microsoft.AspNetCore.Mvc;
using Project.Models;
using System.Diagnostics;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome()
        {
            string name = TempData["UserName"] as string;
            return View("Welcome", name);
        }

        [HttpPost]
        public IActionResult Check(WelcomeToMySite user)
        {
            if (ModelState.IsValid)
            {
                TempData["UserName"] = user.Name;
                return RedirectToAction("Welcome");
            }
            else
            {
                return View("Index");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}