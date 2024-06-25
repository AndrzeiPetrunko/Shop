using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Shop.Entities;
using Shop.Models;

namespace Shop.Repository
{
    public class ProductsRepository : IProductsRepository
    {
        private  readonly ShopDbContext _context;
        public ProductsRepository(ShopDbContext context)
        {
            _context = context;
        }
        public string GetCategoryById(int id)
        {
            var category = _context.ProductCategories.FirstOrDefault(pt => pt.ProductCategoryId == id);
            return category?.CategoryName;
        }
        public IEnumerable<Products> GetAllProducts()
        {
            return _context.Products.ToList();
        }
        public void NewProductAdd(Products product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
      
        public void DeleteProduct(int id)
        {
            Products product = _context.Products.FirstOrDefault(p => p.ProductId == id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChangesAsync();
            }

        }
        public int GetCategoryIdByName(string categoryName)
        {
            var pc = _context.ProductCategories.FirstOrDefault(c => c.CategoryName == categoryName);

            if (pc != null)
            {
                return pc.ProductCategoryId;
            }
            else
            {
                return -1; 
            }
        }
    }
}
