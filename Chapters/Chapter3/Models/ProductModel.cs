namespace Chapter3.Models
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