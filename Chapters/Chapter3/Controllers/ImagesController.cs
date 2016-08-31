using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chapter3.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Chapter3.Controllers
{
    public class ImagesController : Controller
    {
        public IActionResult Employees()
        {
            var employees = new List<EmployeeViewModel>
            {
                new EmployeeViewModel { Id = 1,Name = "Nancy Davolio",JobTitle = "Sales Representative",About ="Education includes a BA in psychology from Colorado State University in 1970.  She also completed 'The Art of the Cold Call.'  Nancy is a member of Toastmasters International."},
                new EmployeeViewModel { Id = 2, Name = "Andrew Fuller", JobTitle = "Vice President, Sales",About ="Andrew received his BTS commercial in 1974 and a Ph.D. in international marketing from the University of Dallas in 1981.  He is fluent in French and Italian and reads German." },
                new EmployeeViewModel { Id = 3, Name = "Janet Leverling", JobTitle = "Sales Representative",About ="Janet has a BS degree in chemistry from Boston College (1984).  She has also completed a certificate program in food retailing management.  Janet was promoted to sales representative in February 1992." },
            };

            return View(employees);
        }

        public IActionResult Figures()
        {


            return View();
        }
    }
}
