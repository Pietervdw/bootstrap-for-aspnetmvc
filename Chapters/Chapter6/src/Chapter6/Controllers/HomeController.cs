using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Chapter6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SalesPerSalesPerson()
        {
            List<object> data = new List<object>();
            data.Add(new string[] { "Product", "Sales" });
            data.Add(new object[] { "Robert King", 530 });
            data.Add(new object[] { "Nancy Davolio", 1012 });
            data.Add(new object[] { "Laura Callahan", 810 });
            data.Add(new object[] { "Janet Leverling", 738 });
            return Json(data);
        }

    }
}
