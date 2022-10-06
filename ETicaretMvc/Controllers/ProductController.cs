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
        public ProductController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }
        [HttpGet]
        public async Task Get()
        {
            _productWriteRepository.AddRangeAsync(new()
            {
                new(){Id=Guid.NewGuid(),Name="Product1",Price=100,CreatedDate=DateTime.Now,Stock=10},
                new(){Id=Guid.NewGuid(),Name="Product2",Price=200,CreatedDate=DateTime.Now,Stock=20},
                new(){Id=Guid.NewGuid(),Name="Product3",Price=300,CreatedDate=DateTime.Now,Stock=30},
            });
            await _productWriteRepository.SaveAsync();
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            return NotFound();
        }
    }
}
