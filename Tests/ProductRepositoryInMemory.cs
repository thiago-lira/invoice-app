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
        private static int id;

        public async Task<Product> GetById(int id)
        {
            await Task.Delay(100);

            return _products
                .Where(p => p.Id == id)
                .FirstOrDefault();
        }

        public Product GetByName(string name)
        {
            return _products
                    .Where(p => p.Name == name)
                    .FirstOrDefault();
        }

        public async Task Save(Product product)
        {
            product.Id = ++id;
            await Task.Delay(100);
            _products.Add(product);
        }
    }
}
