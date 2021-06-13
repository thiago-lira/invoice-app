using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Models;
using Infrastructure;

namespace Tests
{
    public class ProductRepositoryInMemory : IProductRepository
    {
        private readonly List<Product> _products = new();

        public Product GetByName(string name)
        {
            return _products
                    .Where(p => p.Name == name)
                    .FirstOrDefault();
        }

        public async Task Save(Product product)
        {
            await Task.Delay(500);
            _products.Add(product);
        }
    }
}
