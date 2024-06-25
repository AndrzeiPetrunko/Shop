using Microsoft.AspNetCore.Mvc;

namespace Shop.Controllers
{
    public class ProductCategoryController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        }
    }
}
