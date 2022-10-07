using ETicaretMvc.Application.Abstractions;
using ETicaretMvc.Application.Repositories;
using ETicaretMvc.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ETicaretMvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IProductReadRepository _productReadRepository;

        private readonly IOrderWriteRepository _orderWriteRepository;
        private readonly IOrderReadRepository _orderReadRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;
        public ProductController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository, IOrderWriteRepository orderWriteRepository, ICustomerWriteRepository customerWriteRepository, IOrderReadRepository orderReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _orderWriteRepository = orderWriteRepository;
            _customerWriteRepository = customerWriteRepository;
            _orderReadRepository = orderReadRepository;
        }
        [HttpGet]
        public async Task Get()
        {
            Order order = await _orderReadRepository.GetByIdAsync("3bb633b1-66fc-4f6a-8ef4-08daa871783f");
            order.Address = "İstanbul";
            await _orderWriteRepository.SaveAsync();
        }
    }
}
