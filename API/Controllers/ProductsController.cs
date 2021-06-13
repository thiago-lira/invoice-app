using System.Threading.Tasks;
using Core.Features;
using Core.Models;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet("{id:int}")]
        public async Task<Product> GetAsync(int id)
        {
            var handler = new RetrieveProductHandler(_productRepository);
            var command = new RetrieveProduct(id);

            return await handler.Execute(command);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var handler = new CreateProductHandler(_productRepository);
            var command = new CreateProduct(product.Name, product.Price);

            await handler.Execute(command);

            return NoContent();
        }
    }
}
