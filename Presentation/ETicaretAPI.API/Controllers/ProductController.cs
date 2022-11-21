using ETicaretMvc.Application.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private IProductReadRepository productReadRepository;
        private IProductWriteRepository productWriteRepository;
        private IOrderReadRepository orderReadRepository;
        private IOrderWriteRepository orderWriteRepository;
        private ICustomerWriteRepository customerWriteRepository;
        public ProductController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository, IOrderReadRepository orderReadRepository, IOrderWriteRepository orderWriteRepository, ICustomerWriteRepository customerWriteRepository)
        {
            this.productReadRepository = productReadRepository;
            this.productWriteRepository = productWriteRepository;
            this.orderReadRepository = orderReadRepository;
            this.orderWriteRepository = orderWriteRepository;
            this.customerWriteRepository = customerWriteRepository;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
