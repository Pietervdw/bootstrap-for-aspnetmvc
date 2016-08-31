using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Chapter4.Models;

namespace Chapter4.Controllers
{
    public class TabsController : Controller
    {
        public IActionResult Index()
        {
            var vicePresident = new EmployeeModel { Id = 2, Name = "Andrew Fuller", JobTitle = "Vice President, Sales", About = "Andrew received his BTS commercial in 1974 and a Ph.D. in international marketing from the University of Dallas in 1981.  He is fluent in French and Italian and reads German.  He joined the company as a sales representative, was promoted to sales manager in January 1992 and to vice president of sales in March 1993.  Andrew is a member of the Sales Management Roundtable, the Seattle Chamber of Commerce, and the Pacific Rim Importers Association." };
            return View(vicePresident);
        }
    }
}