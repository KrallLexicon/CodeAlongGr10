using CodeAlongGr10.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CodeAlongGr10.Controllers
{
    public class CarOwnerDbController : Controller
    {
        readonly ApplicationDbContext _context;

        public CarOwnerDbController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string id)
        {
            var person = _context.People.Include(x => x.Cars).FirstOrDefault(x => x.Id == id);

            ViewBag.Name = person.Name;
            ViewBag.PersonId = person.Id;

            return View(person.Cars);
        }

        public IActionResult AddCarToPerson()
        {
            ViewBag.People = new SelectList(_context.People, "Id", "Name");
            ViewBag.Cars = new SelectList(_context.Cars, "RegNumber", "RegNumber");
            return View();
        }

        [HttpPost]
        public IActionResult AddCarToPerson(string regnumber, string id)
        {
            var person = _context.People.Include(x => x.Cars).FirstOrDefault(x => x.Id == id);
            var car = _context.Cars.Find(regnumber);

            if(!person.Cars.Any(c=>c.RegNumber == car.RegNumber))
            {
                person.Cars.Add(car);
                _context.SaveChanges();
            }
            else
            {
                ViewBag.People = new SelectList(_context.People, "Id", "Name");
                ViewBag.Cars = new SelectList(_context.Cars.Where(x=>x.RegNumber != regnumber), "RegNumber", "RegNumber");
                ViewBag.Message = $"You already own the car with reg number: {car.RegNumber}!";
                return View(); 
            }


            return RedirectToAction("Index", new { id = id });
        }
        public IActionResult RemoveCarFromPerson(string regnumber, string id)
        {
            var person = _context.People.Include(x => x.Cars).FirstOrDefault(x => x.Id == id);
            var carToRemove = _context.Cars.Find(regnumber);

                person.Cars.Remove(carToRemove);
                _context.SaveChanges();
            return RedirectToAction("Index", new { id = id });
            
        }
    }
}
