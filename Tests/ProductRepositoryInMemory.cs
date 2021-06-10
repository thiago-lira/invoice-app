using System.Collections.Generic;
using System.Linq;
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

        public void Save(Product product)
        {
            _products.Add(product);
        }
    }
}
