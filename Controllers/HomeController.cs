using AdoptionMVClab.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AdoptionMVClab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private AdoptionDbContext _contextDB = new AdoptionDbContext();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ReturnHome(Animal animax)
        {
            _contextDB.Remove(animax);
            _contextDB.SaveChanges();

            return View("Index");
        }

        public IActionResult RehomePet()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPet(Animal a) {

            _contextDB.Animals.Add(a);
            _contextDB.SaveChanges();

            return View("Index");
        }

        public IActionResult Privacy()
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
