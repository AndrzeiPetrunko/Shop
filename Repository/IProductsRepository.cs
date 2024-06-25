using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Shop.Entities;
using Shop.Models;

namespace Shop.Repository
{
    public interface IProductsRepository
    {
       
        public string GetCategoryById(int id);
        public IEnumerable<Products> GetAllProducts();
        public void NewProductAdd(Products product);
        public void DeleteProduct(int id);
        public int GetCategoryIdByName(string name);
        
    }
}
