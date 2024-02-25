using AdoptionMVClab.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdoptionMVClab.Controllers
{
    public class ResultsController : Controller
    {

        private AdoptionDbContext _contextDB = new AdoptionDbContext(); 
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Results()
        {
            String animalType = Request.Form["AnimalType"]!; // value can't be null (drop down menu)
            
            List<Animal> adoptList = _contextDB.Animals.Where(a => a.Type == animalType).ToList();
            if (adoptList.Count == 0) {
                Animal animal = new Animal();
                animal.Type = animalType;
                animal.Age = -1;
                adoptList.Add(animal);
            }
            return View(adoptList);
            
        }

    }
}
