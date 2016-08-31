using System.Collections.Generic;
using cloudscribe.Web.Pagination;

namespace Chapter3.Models
{
    public class ProductPagingViewModel
    {
        public ProductPagingViewModel()
        {
            Paging = new PaginationSettings();
        }

        public string Query { get; set; } = string.Empty;

        public List<ProductModel> Products { get; set; } = null;

        public PaginationSettings Paging { get; set; }
    }
}