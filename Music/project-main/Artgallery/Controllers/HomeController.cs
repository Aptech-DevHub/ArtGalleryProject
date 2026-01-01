using System.Diagnostics;
using Artgallery.Models;
using Microsoft.AspNetCore.Mvc;

namespace Artgallery.Controllers
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

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Painting()
        {
            return View();
        }
        public IActionResult Sketch()
        {
            return View();
        }
        public IActionResult Digitalart()
        {
            return View();
        }
        public IActionResult Sculpture()
        {
            return View();
        }
        public IActionResult Artists()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Signup()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
