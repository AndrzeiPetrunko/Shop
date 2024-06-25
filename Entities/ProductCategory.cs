using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Entities
{
    [Table("ProductCategory", Schema = "Shop")]
    public class ProductCategory
    {
        [Key]
        public int ProductCategoryId { get; set; }
        [Required]
        public string CategoryName {  get; set; }

    }
}
