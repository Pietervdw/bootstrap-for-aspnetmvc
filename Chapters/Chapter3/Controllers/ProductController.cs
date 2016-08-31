using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chapter3.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Chapter3.Controllers
{
    public class ProductController : Controller
    {

        public IActionResult Index(int? page)
        {
            int pageSize = 10;

            var currentPageNum = page.HasValue ? page.Value : 1;
            var offset = (pageSize * currentPageNum) - pageSize;
            var model = new ProductPagingViewModel();
            model.Products = GetProducts()
                .Skip(offset)
                .Take(pageSize).OrderBy(p=>p.Name)
                .ToList();

            model.Paging.CurrentPage = currentPageNum;
            model.Paging.ItemsPerPage = pageSize;
            model.Paging.TotalItems = GetProducts().Count;

            return View(model);
        }

        private List<ProductModel> GetProducts()
        {
            var model = new List<ProductModel>
            {
                new ProductModel { Name = "Chai", UnitPrice = 18, UnitsInStock = 35, Discontinued = false, Id = 1, Status = "active"},
                new ProductModel { Name = "Chang", UnitPrice = 19, UnitsInStock = 17, Discontinued = false, Id = 2,Status = "success"},
                new ProductModel { Name = "Aniseed Syrup", UnitPrice = 10, UnitsInStock = 13, Discontinued = false, Id = 3, Status = "info" },
                new ProductModel { Name = "Pavlova", UnitPrice = 17, UnitsInStock = 29, Discontinued = false, Id = 4, Status = "warning" },
                new ProductModel { Name = "Carnarvon Tigers", UnitPrice = 62, UnitsInStock = 42, Discontinued = true, Id = 5, Status = "danger" },
                new ProductModel { Name = "Chef Anton's Cajun Seasoning", UnitPrice = 22, UnitsInStock = 53, Discontinued = false, Id = 6, Status = "active" },
                new ProductModel { Name = "Chef Anton's Gumbo Mix", UnitPrice = 21, UnitsInStock = 0, Discontinued = true, Id = 7, Status = "danger" },
                new ProductModel { Name = "Grandma's Boysenberry Spread", UnitPrice = 25, UnitsInStock = 120, Discontinued = false, Id = 8, Status = "active" },
                new ProductModel { Name = "Uncle Bob's Organic Dried Pears", UnitPrice = 30, UnitsInStock = 15, Discontinued = false, Id = 9, Status = "active" },
                new ProductModel { Name = "Northwoods Cranberry Sauce", UnitPrice = 50, UnitsInStock = 6, Discontinued = false, Id = 10, Status = "active" },
                new ProductModel { Name = "Mishi Kobe Niku", UnitPrice = 97, UnitsInStock = 29, Discontinued = true, Id = 11, Status = "danger" },
                new ProductModel { Name = "Ikura", UnitPrice = 31, UnitsInStock = 60, Discontinued = false, Id = 12, Status = "active" },
                new ProductModel { Name = "Queso Cabrales", UnitPrice = 21, UnitsInStock = 14, Discontinued = false, Id = 13, Status = "active" },
            };


            return model;
        }

    }
}
