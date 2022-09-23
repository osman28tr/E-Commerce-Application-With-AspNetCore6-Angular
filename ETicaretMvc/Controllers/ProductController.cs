using ETicaretMvc.Application.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretMvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult GetProducts()
        {
            var products = _productService.GetProducts();
            return View(products);
        }
    }
}
