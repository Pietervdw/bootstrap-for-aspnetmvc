using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Chapter4.Controllers
{
    public class CarouselController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}