using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chapter7.Models
{
    public class Customer
    {
        public string CustomerCode { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}