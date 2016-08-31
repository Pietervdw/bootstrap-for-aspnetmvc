using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Chapter2.Controllers
{
    public class ButtonsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}