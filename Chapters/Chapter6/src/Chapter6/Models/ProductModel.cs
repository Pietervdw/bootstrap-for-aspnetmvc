using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter6.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public bool Discontinued { get; set; }
        public string Status { get; set; }
    }
}
