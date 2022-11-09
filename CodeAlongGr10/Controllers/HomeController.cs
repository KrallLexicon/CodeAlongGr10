using CodeAlongGr10.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeAlongGr10.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Index()
        {
            if (PersonViewModel.listOfPeople.Count == 0)
                PersonViewModel.GeneratePeople();

            PersonViewModel vm = new PersonViewModel();

            vm.tempList = PersonViewModel.listOfPeople;

            return View(vm);
        }
        public IActionResult About()
        {
            ViewBag.Message = "This is a message from the controller!";
            return View();
        }
    }
}
