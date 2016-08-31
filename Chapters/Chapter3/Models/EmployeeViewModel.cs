using System.Collections.Generic;

namespace Chapter3.Models
{
    public class EmployeeViewModel
    {
        public EmployeeViewModel()
        {
            ReportingEmployees = new List<EmployeeViewModel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobTitle { get; set; }
        public string About { get; set; }
        public int? ReportsTo { get; set; }

        public List<EmployeeViewModel> ReportingEmployees { get; set; }
    }
}