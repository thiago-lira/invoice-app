using System.Threading.Tasks;
using Core.Features;
using Core.Models;
using Infrastructure;

namespace Services
{
    public class CreateProductHandler
    {
        private readonly IProductRepository _repository;

        public CreateProductHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task Execute(CreateProduct createProduct)
        {
            var product = new Product()
            {
                Name = createProduct.Name,
                Price = createProduct.Price
            };

            await _repository.Save(product);
        }
    }
}
