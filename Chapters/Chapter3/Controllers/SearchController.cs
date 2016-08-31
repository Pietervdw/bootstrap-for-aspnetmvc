using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chapter3.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Chapter3.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult Index(string query)
        {
            ViewBag.SearchQuery = query;
            var products = GetProducts();
            if (!string.IsNullOrEmpty(query))
            {
                var results = products.Where(p => p.Name.Contains(query));
                return View(results);
            }
            return View(products);
        }

        public IActionResult SearchEmployees(string query)
        {
            ViewBag.SearchQuery = query;
            var employees = GetEmployees();
            if (!string.IsNullOrEmpty(query))
            {
                var results = employees.Where(p => p.Name.Contains(query));
                return View(results);
            }
            return View(employees);
        }

        private List<ProductModel> GetProducts()
        {
            var model = new List<ProductModel>();
            var product1 = new ProductModel { Name = "Chai", UnitPrice = 18, UnitsInStock = 35, Discontinued = false, Id = 1, Status = "active" };
            var product2 = new ProductModel { Name = "Chang", UnitPrice = 19, UnitsInStock = 17, Discontinued = false, Id = 2, Status = "success" };
            var product3 = new ProductModel { Name = "Aniseed Syrup", UnitPrice = 10, UnitsInStock = 13, Discontinued = false, Id = 3, Status = "info" };
            var product4 = new ProductModel { Name = "Pavlova", UnitPrice = 17, UnitsInStock = 29, Discontinued = false, Id = 4, Status = "warning" };
            var product5 = new ProductModel { Name = "Carnarvon Tigers", UnitPrice = 62, UnitsInStock = 42, Discontinued = true, Id = 5, Status = "danger" };
            model.AddRange(new[] { product1, product2, product3, product4, product5 });
            return model;
        }

        private List<EmployeeViewModel> GetEmployees()
        {
            var vicePresident = new EmployeeViewModel
            {
                Id = 2,
                Name = "Andrew Fuller",
                JobTitle = "Vice President, Sales",
                ReportsTo = null
            };

            var reportingEmployees = new List<EmployeeViewModel>
            {
                new EmployeeViewModel { Id = 1, Name = "Nancy Davolio",JobTitle = "Sales Representative", ReportsTo = 2},
                new EmployeeViewModel { Id = 3, Name = "Janet Leverling", JobTitle = "Sales Representative", ReportsTo = 2 },
                new EmployeeViewModel { Id = 4, Name = "Laura Callahan", JobTitle = "Inside Sales Coordinator", ReportsTo = 2 }
            };

            vicePresident.ReportingEmployees = reportingEmployees;
            var employees = new List<EmployeeViewModel> { vicePresident };

            return employees;
        }
    }
}
