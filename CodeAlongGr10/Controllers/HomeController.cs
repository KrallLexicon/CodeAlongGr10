using Microsoft.AspNetCore.Mvc;

namespace CodeAlongGr10.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
