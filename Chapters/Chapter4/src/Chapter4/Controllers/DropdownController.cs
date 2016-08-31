using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chapter4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Chapter4.Controllers
{
    public class DropdownController : Controller
    {
        private EmployeeModel GetEmployees(int id = 2)
        {
            if (id == 2)
            {
                var vicePresident = new EmployeeModel { Id = 2, Name = "Andrew Fuller", JobTitle = "Vice President, Sales", ReportsTo = null };
                var vicePresidentEmployees = new List<EmployeeModel>
                {
                    new EmployeeModel { Id = 1, Name = "Nancy Davolio",JobTitle = "Sales Representative", ReportsTo = 2},
                    new EmployeeModel { Id = 3, Name = "Janet Leverling", JobTitle = "Sales Representative", ReportsTo = 2 },
                    new EmployeeModel { Id = 4, Name = "Laura Callahan", JobTitle = "Inside Sales Coordinator", ReportsTo = 2 }
                };
                vicePresident.ReportingEmployees = vicePresidentEmployees;
                return vicePresident;
            }


            var salesManager = new EmployeeModel { Id = 5, Name = "Steven Buchanan", JobTitle = "Sales Manager", ReportsTo = null };
            var salesManagerEmployees = new List<EmployeeModel>
            {
                new EmployeeModel { Id = 1, Name = "Michael Suyama",JobTitle = "Sales Representative", ReportsTo = 5 },
                new EmployeeModel { Id = 3, Name = "Robert King", JobTitle = "Sales Representative", ReportsTo = 5 },
                new EmployeeModel { Id = 4, Name = "Anne Dodsworth", JobTitle = "Inside Sales Coordinator", ReportsTo = 5 }
            };
            salesManager.ReportingEmployees = salesManagerEmployees;

            return salesManager;
        }

        public IActionResult Index(int id = 2)
        {
            var managers = new List<EmployeeModel>();
            var vicePresident = new EmployeeModel { Id = 2, Name = "Andrew Fuller", JobTitle = "Vice President, Sales", ReportsTo = null };
            var salesManager = new EmployeeModel { Id = 5, Name = "Steven Buchanan", JobTitle = "Sales Manager", ReportsTo = null };
            managers.Add(vicePresident);
            managers.Add(salesManager);

            ViewBag.Managers = managers;
            var model = GetEmployees(id);
            return View(model);
        }

        public PartialViewResult GetReportingEmployees(int id)
        {
            var model = GetEmployees(id);
            return PartialView("_employees", model.ReportingEmployees);
        }
    }
}
