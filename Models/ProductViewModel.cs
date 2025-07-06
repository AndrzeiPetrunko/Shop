using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Entities;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        
        public int ProductCategoryId { get; set; }
        public string? ProductName { get; set; }
        
        public List<SelectList>? productCategories { get; set; }
        
        public float ProductPrice { get; set; }
        
        public DateTime DateOfExpire { get; set; }
        
        public int ProductCount { get; set; }
        
        public float Discount { get; set; }
        public string? CategoryName { get; set; }
    }
}
