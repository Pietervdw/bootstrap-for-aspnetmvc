using Microsoft.AspNetCore.Mvc;
namespace BS4App.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
