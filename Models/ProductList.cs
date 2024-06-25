namespace Shop.Models
{
    public class ProductList
    {
        public int ProductId { get; set; }
        public float ProductPrice { get; set; }
        public int ProductCategoryId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public DateTime DateOfExpire { get; set; }
        public int ProductCount { get; set; }
        public float Promotion { get; set; }
    }
}
