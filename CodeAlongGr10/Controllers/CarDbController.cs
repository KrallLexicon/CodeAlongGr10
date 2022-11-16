using CodeAlongGr10.Data;
using CodeAlongGr10.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeAlongGr10.Controllers
{
    public class CarDbController : Controller
    {
        readonly ApplicationDbContext _context;

        public CarDbController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Cars.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Car car)
        {
            if(ModelState.IsValid)
            {
                _context.Cars.Add(car);
                _context.SaveChanges(); 
            }

            return RedirectToAction("Index");
        }

        public IActionResult Delete(string regnumber)
        {
            var carToRemove = _context.Cars.Find(regnumber);
            
            if(carToRemove != null)
            {
                _context.Cars.Remove(carToRemove);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
