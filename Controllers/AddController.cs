using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Shop.Entities;
using Shop.Models;
using Shop.Repository;

namespace Shop.Controllers
{
    public class AddController : Controller
    {
        private readonly ShopDbContext _context;
        private IProductsRepository _productsRepository;
        public AddController(ShopDbContext context, IProductsRepository productsRepository)
        {
            _context = context;
            _productsRepository = productsRepository;
        }
        public IActionResult AddNew(ProductViewModel viewModel)
        {
            {
                List<ProductViewModel> list = new List<ProductViewModel>();
                var listOfCategories = _context.ProductCategories.ToList();
                foreach (var item in listOfCategories)
                {
                    list.Add(new ProductViewModel()
                    {
                        ProductCategoryId = item.ProductCategoryId,
                        CategoryName = item.CategoryName,
                    });
                    

                }


                ViewBag.List = list;
                return View();
            }
        }
        public IActionResult AddProduct(ProductViewModel viewModel) 
        {
            
            Products p = new Products()
            {
                ProductName = viewModel.ProductName,
                ProductCategoryId = viewModel.ProductCategoryId ,
                ProductCount = viewModel.ProductCount,
                DateOfExpire = viewModel.DateOfExpire,
                ProductPrice = viewModel.ProductPrice,
                Discount = viewModel.Discount,
            };
            if (viewModel.ProductName == null  ) 
            {
                TempData["AlertMessage"] = "Product name cannot be null or empty.";
                return RedirectToAction("AddNew", "Add");
            } else if(viewModel.Discount == 0)
            {
                TempData["AlertMessage"] = "Choose the discount!";
                return RedirectToAction("AddNew", "Add");
            }
            
            _productsRepository.NewProductAdd(p);
            return RedirectToAction("Index","Product");
        }
    }
}
