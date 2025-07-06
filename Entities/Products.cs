using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace Shop.Entities
{
    [Table("Products", Schema = "Shop")]
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [ForeignKey("ProductCategory")]
        public int ProductCategoryId { get; set; }
        [Required(ErrorMessage = "Product name is required.")]
        public string? ProductName { get; set; }
        [Required]
        public float ProductPrice { get; set; }
        [Required]
        public DateTime DateOfExpire { get; set; }
        [Required]
        public int ProductCount { get; set; }
        [Required]
        public float Discount { get; set; }

    }
}
