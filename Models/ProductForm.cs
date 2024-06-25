using Shop.Entities;

namespace Shop.Models
{
    public class ProductForm
    {

        public int ProductCategoryId { get; set; }
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
        public DateTime DateOfExpire { get; set; }
        public int ProductCount { get; set; }
        public float Promotion { get; set; }
    }
}
