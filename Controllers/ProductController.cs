using Microsoft.AspNetCore.Mvc;
using Shop.Entities;
using Shop.Models;
using Shop.Repository;
using System.Diagnostics;

namespace Shop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductsRepository _productsRepository;
        private ShopDbContext _context;
        public ProductController(IProductsRepository reservationRepository, ShopDbContext shopDbContext)
        {
            _productsRepository = reservationRepository;
            _context = shopDbContext;
        }
        public IActionResult Index()
        {
            var products = _productsRepository.GetAllProducts();
            var viewModel = products.Select(p => new ProductList()
            {
                ProductPrice = p.ProductPrice,
                ProductName = p.ProductName,
                DateOfExpire = p.DateOfExpire,
                ProductCategoryId = p.ProductCategoryId,
                CategoryName = _productsRepository.GetCategoryById(p.ProductCategoryId),
                ProductCount = p.ProductCount,
                Discount = p.Discount,
                ProductId = p.ProductId,
            }).ToList();
            return View(viewModel);
        }
        public IActionResult Add()
        {
            return RedirectToAction("AddNew", "Add");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            _productsRepository.DeleteProduct(id);
            return RedirectToAction("Index", "Product");
        }
            
            
        
    }
}
