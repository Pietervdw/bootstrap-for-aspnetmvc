using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Chapter5.Controllers
{
    public class TagHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Button()
        {
            return View();
        }

        public IActionResult Alert()
        {
            return View();
        }
    }
}
